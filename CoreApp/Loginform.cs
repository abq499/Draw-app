﻿using Dreaw.WorldForm;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dreaw
{
    public partial class Loginform : Form
    {
        const string serverAdd = "https://d341-2402-800-6388-2a9c-4456-43d5-f-49e5.ngrok-free.app";
        bool isSending = false;
        public Loginform()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Khởi tạo và mở form Sign in
            Siginform newForm = new Siginform();
            newForm.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Khởi tạo và mở Forget PW
            forgetpw newForm = new forgetpw();
            newForm.Show();
            this.Close();
        }

        private async void pictureBox3_Click(object sender, EventArgs e)
        {
            if (isSending)
            {
                MessageBox.Show("Completed the last request first!");
                return;
            }
            string email = txtEmail.Text.Trim();
            string password = txtPass.Text.Trim();
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter email and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var requestData = new
            {
                Email = email,
                Password = password
            };
            using (var client = new HttpClient())
            {
                isSending = true;
                var jsonRequest = JsonConvert.SerializeObject(requestData);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
                Cursor.Current = Cursors.WaitCursor;
                var response = await client.PostAsync($"{serverAdd}/api/login", content); //này y chang ha, khác endpoint
                if (response.IsSuccessStatusCode)
                {
                    //Này khác xíu, không dùng convert thành dynamic object mà convert thành JObject
                    // Đọc nội dung phản hồi dưới dạng chuỗi
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Phân tích chuỗi JSON
                    var jsonResponse = JObject.Parse(responseBody);
                    MessageBox.Show("Sign in successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    isSending = false;
                    Cursor.Current = Cursors.Default;
                    var name = jsonResponse["name"].ToString(); //Lấy ra name
                    var userID = jsonResponse["userID"].ToString(); //Lấy ra userID
                    List<userRoom> userRooms = new List<userRoom>();
                    using (var clientJR = new HttpClient())
                    {
                        var contentJR = new StringContent(userID, Encoding.UTF8, "text/plain");
                        var responseJR = await clientJR.PostAsync($"{serverAdd}/api/room/getroomlist", contentJR);
                        var jsoncontentJR = await responseJR.Content.ReadAsStringAsync();
                        // Parse JSON thành đối tượng động (dynamic)
                        JArray roomList = JArray.Parse(jsoncontentJR);

                        // Duyệt qua từng phòng và hiển thị
                        foreach (var room in roomList)
                        {
                            string roomName = room["roomName"].ToString();
                            string lastModified = room["lastModified"].ToString();
                            string roomID = room["roomID"].ToString();
                            userRooms.Add(new userRoom(roomName, lastModified, Convert.ToInt32(roomID)));
                        }
                    }    
                    world newForm = new world(name, userID, userRooms); //Tạo form world với tên người dùng và userID
                    newForm.Show();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized) //Sai email hoặc pass
                {
                    MessageBox.Show("Invalid Email or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cursor.Current = Cursors.Default;
                    isSending = false;
                    return;
                }
                else //Lỗi server
                {
                    MessageBox.Show("Something wrong happened!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cursor.Current = Cursors.Default;
                    isSending = false;
                    return;
                } 
                    
            }
        }

        private bool IsValidEmail(string email)
        {
            // Sử dụng Regex để kiểm tra định dạng email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}
