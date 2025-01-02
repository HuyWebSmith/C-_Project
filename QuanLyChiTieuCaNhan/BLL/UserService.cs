using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.Models;

namespace BLL
{
    public class UserService
    {
        public List<User> GetAll()
        {
            SpendingManagerDBContext context = new SpendingManagerDBContext();
            return context.Users.ToList();
        }

        public bool InsertUser(User newUser)    
        {
            try
            {
                SpendingManagerDBContext context = new SpendingManagerDBContext();
                context.Users.Add(newUser);
                return context.SaveChanges() > 0; // trả về true nếu có ít nhất 1 dòng bị ảnh hưởng
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            } 
        }

        public bool UpdateUser(User updatedUserID)
        {
            try
            {
                SpendingManagerDBContext context = new SpendingManagerDBContext();

                var existingUser = context.Users.FirstOrDefault(u => u.UserID == updatedUserID.UserID);

                if (existingUser != null)
                {
                    existingUser.Username = updatedUserID.Username;
                    existingUser.FullName = updatedUserID.FullName;
                    existingUser.Email = updatedUserID.Email;
                    existingUser.Phone = updatedUserID.Phone;

                    return context.SaveChanges() > 0;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DeleteUser(string deleteUserID)
        {
            SpendingManagerDBContext context = new SpendingManagerDBContext();
            var user = context.Users.FirstOrDefault(u => u.UserID == deleteUserID);
                if (user != null)
                {
                    context.Users.Remove(user);
                    return context.SaveChanges() > 0;
                }
                return false;
        }

        public User Login(string username, string password)
        {
            SpendingManagerDBContext context = new SpendingManagerDBContext();
            return context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public bool IsUsernameHas(string username)
        {
            SpendingManagerDBContext context = new SpendingManagerDBContext();
            return context.Users.Any(u => u.Username == username);
        }
    }
}
