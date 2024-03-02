using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace UseBank
{
    public class Bank
    {
        private XDocument xmlDoc = XDocument.Load("DataBase.xml");
        private XElement user;
        private string login, password;
        public double balance = 0;
        public Bank(String login, String password)
        {
            this.login = login;
            this.password = password;
        }

        public bool authorization()
        {
            var users = xmlDoc.Root.Elements("user"); // Получение всех пользователей

            foreach (var user in users) // Поиск нашего пользователя и авторизация
                if (login == user.Attribute("login").Value && password == user.Attribute("password").Value)
                {
                    this.user = user;
                    return true;
                }

            this.user = null;
            return false;
        }

        public bool registration()
        {
            // Добавление нового пользователя
            XElement newUser = new XElement("user");
            newUser.SetAttributeValue("login", login);
            newUser.SetAttributeValue("password", password);
            newUser.Add(new XElement("balance", 0));

            xmlDoc.Root.Add(newUser);
            user = newUser;

            xmlDoc.Save("DataBase.xml"); // Сохранение изменений в XML-файле

            return true;
        }

        public bool replenishMoney(double balance)
        {
            this.balance = Double.Parse(user.Element("balance").Value);
            this.balance += balance;
            user.SetElementValue("balance", this.balance);
            xmlDoc.Save("DataBase.xml"); // Сохранение изменений в XML-файле
            addHistoryOperation("взнос", balance);
            return true;
        }

        public bool withdrawMoney(double balance)
        {
            this.balance = Double.Parse(user.Element("balance").Value);
            if (this.balance >= balance)
            {
                this.balance -= balance;
                user.SetElementValue("balance", this.balance);
                xmlDoc.Save("DataBase.xml"); // Сохранение изменений в XML-файле
                addHistoryOperation("снятие", balance);
                return true;
            }
            return false;
        }

        public bool transferMoney(string otherUser, double balance)
        {
            this.balance = Double.Parse(user.Element("balance").Value);
            var users = xmlDoc.Root.Elements("user"); // Получение всех пользователей

            foreach (var user in users) // Поиск нашего пользователя и авторизация
                if (otherUser == user.Attribute("login").Value)
                {
                    bool res = withdrawMoney(balance);
                    if (res)
                    {
                        double userBalance = Double.Parse(user.Element("balance").Value);
                        user.Element("balance").Value = (userBalance - balance).ToString();
                        xmlDoc.Save("DataBase.xml"); // Сохранение изменений в XML-файле
                        addHistoryOperation("перевод", balance);
                        return true;
                    }
                    return false;
                }
            return false;
        }

        public double getBalance()
        {
            return balance = Double.Parse(user.Element("balance").Value);
        }

        public string getLogin()
        {
            return login;
        }

        public string getPassword()
        {
            return password;
        }

        // Проверяет валидный ли (доступный) логин.
        // Потом измени название функции, иначе я написал как помню слово
        public static bool getValidiLogin(string login)
        {
            XDocument xmlDoc = XDocument.Load("DataBase.xml");
            var users = xmlDoc.Root.Elements("user"); // Получение всех пользователей

            foreach (var user in users) // Поиск нашего пользователя и авторизация
                if (login == user.Attribute("login").Value)
                    return false;
            return true;
        }

        public void getHistoryOperations() { }

        private void addHistoryOperation(string operation, double money)
        {
            var users = xmlDoc.Root.Elements("user"); // Получение всех пользователей

            foreach (var user in users) // Поиск нашего пользователя и авторизация
                if (login == user.Attribute("login").Value && password == user.Attribute("password").Value)
                {
                    XElement newElement = new XElement("operation");
                    newElement.SetAttributeValue("type", operation);
                    newElement.SetAttributeValue("money", money); ;
                    newElement.SetAttributeValue("time", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
                    xmlDoc.Root.Element("user").SetElementValue("operation", newElement);
                    xmlDoc.Save("DataBase.xml"); // Сохранение изменений в XML-файле
                }
        }
    }
}
