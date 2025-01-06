using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.enums;
using DAL.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BLL
{
    public class GoalsService
    {
        public List<Goals> GetAllByUser(int userId)
        {
            SpendingManagerDBContext _context = new SpendingManagerDBContext();
            return _context.Goals.Where(t => t.UserID == userId).ToList();
        }

        
        public bool InsertGoal(Goals goal)
        {
            try
            {
                SpendingManagerDBContext _context = new SpendingManagerDBContext();
                _context.Goals.Add(goal);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm giao dịch: {ex.Message}");
                return false;
            }
        }

        public bool DeleteGoal(int goalID)
        {
            try
            {
                SpendingManagerDBContext _context = new SpendingManagerDBContext();
                var goals = _context.Goals.FirstOrDefault(g => g.GoalID == goalID);
                if (goals != null)
                {
                    _context.Goals.Remove(goals);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateGoal(Goals goal)
        {
            try
            {
                SpendingManagerDBContext _context = new SpendingManagerDBContext();
                var goals = _context.Goals.FirstOrDefault(t => t.GoalID == goal.GoalID);
                if (goals != null)
                {
                    goals.GoalName = goal.GoalName;
                    goals.TargetAmount = goal.TargetAmount;
                    goals.DueDate = goal.DueDate;
                    
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateStatus(Goals goal, DAL.enums.Status status)
        {
            try
            {
                SpendingManagerDBContext _context = new SpendingManagerDBContext();
                var goals = _context.Goals.FirstOrDefault(t => t.GoalID == goal.GoalID);
                if (goals != null)
                {
                    goals.GoalName = goal.GoalName;
                    goals.TargetAmount = goal.TargetAmount;
                    goals.DueDate = goal.DueDate;
                    goals.Status = status;

                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public Goals GetById(int goalID)
        {
            try
            {
                SpendingManagerDBContext _context = new SpendingManagerDBContext();
                // Tìm mục tiêu dựa trên GoalID trong cơ sở dữ liệu
                var goal = _context.Goals.FirstOrDefault(g => g.GoalID == goalID);

                // Nếu không tìm thấy, trả về null
                if (goal == null)
                {
                    throw new Exception("Mục tiêu không tồn tại.");
                }

                return goal;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy mục tiêu: {ex.Message}");
            }
        }
    }
}
