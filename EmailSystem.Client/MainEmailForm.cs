using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using EmailSystem.Client.ResponseModels;
using EmailSystem.Domain;
using Newtonsoft.Json;

namespace EmailSystem.Client
{
    public partial class MainEmailForm : Form
    {
        private EmployeesResponse? _employees;

        public MainEmailForm()
        {
            InitializeComponent();
            GetEmployees();
        }

        private void GetEmployees()
        {
            var clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            using (var client = new HttpClient(clientHandler))
            {
                try
                {
                    var response = client.GetAsync("https://localhost:5001/api/Employee").Result;
                    response.EnsureSuccessStatusCode();
                    var responseBody = response.Content.ReadAsStringAsync().Result;
                    _employees = JsonConvert.DeserializeObject<EmployeesResponse>(responseBody);

                    if (_employees == null)
                    {
                        return;
                    }

                    foreach (var employee in _employees.Employees)
                    {
                        recipientCB.Items.Add($"{employee.SecondName} {employee.FirstName} {employee.GivenName}");
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
        }

        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(recipientCB.Text))
            {
                MessageBox.Show("Выберите получателя", "Ошибка");
                return;
            }

            if (string.IsNullOrEmpty(nameTB.Text))
            {
                MessageBox.Show("Заполните название письма", "Ошибка");
                return;
            }

            if (string.IsNullOrEmpty(contentTB.Text))
            {
                MessageBox.Show("Заполните содержание письма", "Ошибка");
                return;
            }

            PostEmail();
        }

        private void PostEmail()
        {
            var fullName = recipientCB.Text.Split(' ');
            var currentEmployee = _employees?.Employees.FirstOrDefault(x => x.SecondName == fullName[0] && x.FirstName == fullName[1] && x.GivenName == fullName[2]);

            if (currentEmployee == null)
            {
                return;
            }

            var email = new Email
            {
                Id = Guid.NewGuid(),
                Name = nameTB.Text,
                RecipientId = currentEmployee.Id,
                SenderId = Guid.Parse("64b55038-737f-4739-9926-67741c7e96ac"),
                SentOn = DateTime.Now,
                Content = contentTB.Text
            };
            var emailJson = JsonConvert.SerializeObject(email);
            var data = new StringContent(emailJson, Encoding.UTF8, "application/json");

            var clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            using (var client = new HttpClient(clientHandler))
            {
                try
                {
                    var response = client.PostAsync("https://localhost:5001/api/Email", data).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                    nameTB.Text = string.Empty;
                    contentTB.Text = string.Empty;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

    }
}
