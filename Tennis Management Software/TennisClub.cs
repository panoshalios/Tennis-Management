using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using Tennis_Management_Software.Imaging;
using Tennis_Management_Software.Saving;

namespace Tennis_Management_Software
{
    [Serializable]
    public class TennisClub
    {
        public static string MainFolderName = "Tennis Management Information";
        public static string SaveFilePath = MainFolderName + "\\" + "TennisManagementSoftware.tms";
        public static string StudentPicturesFolder = MainFolderName + "\\" + "StudentPictures";
        public static string CoachPictureFolder = MainFolderName + "\\" + "CoachesPictures";
        private const string fileType = ".png"; 

        private List<Student> studentList;
        public Student[] StudentList
        {
            get
            {
                return studentList.ToArray();
            }
        }
        public string[] StudentFullNameList
        {
            get
            {
                string[] names = new string[studentList.Count];
                for (int i = 0; i < studentList.Count; i++)
                    names[i] = studentList[i].FullName;
                return names;
            }
        }

        private List<Coach> coachList;
        public Coach[] CoachList
        {
            get
            {
                return coachList.ToArray();
            }
        }
        public string[] CoachFullNameList
        {
            get
            {
                string[] names = new string[coachList.Count];
                for (int i = 0; i < coachList.Count; i++)
                    names[i] = coachList[i].FullName;
                return names;
            }
        }

        private LessonFees lesson_Fees;
        public LessonFees Lesson_Fees
        {
            get
            {
                return lesson_Fees;
            }
            set
            {
                lesson_Fees = value;
                this.Save();
            }
        }

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.TennisClub class.
        /// </summary>
        public TennisClub()
        {
            studentList = new List<Student>();
            coachList = new List<Coach>();
            lesson_Fees = new LessonFees();

            CreateFolderIfNotExist(MainFolderName);
            CreateFolderIfNotExist(StudentPicturesFolder);
            CreateFolderIfNotExist(CoachPictureFolder);
        }

        /// <summary>
        /// Saves all infomation.
        /// </summary>
        public void Save()
        {
            Serialization.Serialize(this, SaveFilePath,false);
        }

        /// <summary>
        /// Loads all the information.
        /// </summary>
        public void Load()
        {
            TennisClub tempClass = Serialization.Deserialize<TennisClub>(SaveFilePath);
            this.studentList = tempClass.studentList;
            this.coachList = tempClass.coachList;
            this.lesson_Fees = tempClass.lesson_Fees;
        }

        /// <summary>
        /// Returns an array of Student which their Name field starts with the parameter value.
        /// </summary>
        /// <param name="name">The name of the Student.</param>
        /// <returns></returns>
        public Student[] SearchStudents(string name)
        {
            var searchResults = from student in studentList
                                where student.Name.ToLower().StartsWith(name.ToLower())
                                select student;

            return searchResults.ToArray();
        }

        /// <summary>
        /// Returns an array of Student which their Name and Surname field starts with the parameter values.
        /// </summary>
        /// <param name="name">The name of the Student.</param>
        /// <param name="surname">The surname of the Student.</param>
        /// <returns></returns>
        public Student[] SearchStudents(string name, string surname)
        {
            var searchResult = from student in studentList
                               where student.Name.ToLower().StartsWith(name.ToLower()) && student.Surname.ToLower().StartsWith(surname.ToLower())
                               select student;
            
            return searchResult.ToArray();
        }

        /// <summary>
        /// Returns an array of Coach which their Name field starts with the parameter value.
        /// </summary>
        /// <param name="name">The name of the Coach.</param>
        /// <returns></returns>
        public Coach[] SearchCoaches(string name)
        {
            var searchResults = from coach in coachList
                                where coach.Name.ToLower().StartsWith(name.ToLower())
                                select coach;

            return searchResults.ToArray();
        }

        /// <summary>
        /// Returns an array of Student which their Name and Surname field starts with the parameter values.
        /// </summary>
        /// <param name="name">The name of the Coach.</param>
        /// <param name="surname">The surname of the Coach.</param>
        /// <returns></returns>
        public Coach[] SearchCoaches(string name, string surname)
        {
            var searchResults = from coach in coachList
                                where coach.Name.ToLower().StartsWith(name) && coach.Surname.ToLower().StartsWith(surname)
                                select coach;

            return searchResults.ToArray();
        }

        /// <summary>
        /// Returns the image of the specified Student if it exists. If the image does not exist null will be returned.
        /// </summary>
        /// <param name="indexOfStudent">Specifies which Student.</param>
        /// <returns></returns>
        public Image GetStudentImage(int indexOfStudent)
        {
            if (indexOfStudent > studentList.Count - 1 || indexOfStudent < 0)
                throw new IndexOutOfRangeException("The index was out of range");

            string filePath = StudentPicturesFolder + "\\" + studentList[indexOfStudent].FullNameAndID + fileType;

            if(File.Exists(filePath) && !ImageHandling.IsImageCorrupted(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    return Image.FromStream(fs);
                }
            }
            return null;
        }

        /// <summary>
        /// Returns the image of the specified Coach if it exists. If the image does not exist null will be returned.
        /// </summary>
        /// <param name="indexOfCoach">Specifies which Coach.</param>
        /// <returns></returns>
        public Image GetCoachImage(int indexOfCoach)
        {
            if (indexOfCoach > coachList.Count - 1 || indexOfCoach < 0)
                throw new IndexOutOfRangeException("The index was out of range");

            string filePath = CoachPictureFolder + "\\" + coachList[indexOfCoach].FullNameAndID + fileType;

            if (File.Exists(filePath) && !ImageHandling.IsImageCorrupted(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    return Image.FromStream(fs);
                }
            }
            return null;
        }

        /// <summary>
        /// Adds a Student at the end of the StudentList and saves the Student.
        /// </summary>
        /// <param name="student">The Student object.</param>
        /// <param name="picture">The picture of the Student.</param>
        public void AddStudent(Student student, Image picture)
        {
            if (student != null)
            {
                studentList.Add(student);
                this.Save();
            }

            Tennis_Management_Software.Imaging.ImageHandling.SaveImage(picture, StudentPicturesFolder + "\\" + student.FullNameAndID + fileType, System.Drawing.Imaging.ImageFormat.Png);
        }

        /// <summary>
        /// Adds a Coach at the end of the CoachList and saves the Coach.
        /// </summary>
        /// <param name="coach">The Coach object.</param>
        /// <param name="picture">The picture of the Coach.</param>
        public void AddCoach(Coach coach, Image picture)
        {
            if(coach != null)
            {
                coachList.Add(coach);
                this.Save();
            }

            Tennis_Management_Software.Imaging.ImageHandling.SaveImage(picture, CoachPictureFolder + "\\" + coach.FullNameAndID + fileType, System.Drawing.Imaging.ImageFormat.Png);
        }

        /// <summary>
        /// Removes a Student at the specified index and saves the list.
        /// </summary>
        /// <param name="indexOfStudent">Specifies which Student to remove.</param>
        public void RemoveStudent(int indexOfStudent)
        {
            if (indexOfStudent > studentList.Count - 1 || indexOfStudent < 0)
                throw new IndexOutOfRangeException();

            studentList.RemoveAt((int)indexOfStudent);

            File.Delete(StudentPicturesFolder + "\\" + studentList[indexOfStudent].FullNameAndID + fileType);

            string from, to;
            for (int i = indexOfStudent; i < studentList.Count; i++)
            {

                from = StudentPicturesFolder + "\\" + studentList[i].FullNameAndID + fileType;
                studentList[i].ID--;
                to = StudentPicturesFolder + "\\" + studentList[i].FullNameAndID + fileType;
                RenameFileName(from, to);
            }
            this.Save();
        }

        /// <summary>
        /// Removes a Coach at the specified index and saves the list.
        /// </summary>
        /// <param name="indexOfCoach">Specifies which Coach to remove.</param>
        public void RemoveCoach(int indexOfCoach)
        {
            if (indexOfCoach > coachList.Count - 1 || indexOfCoach < 0)
                throw new IndexOutOfRangeException();

            coachList.RemoveAt((int)indexOfCoach);

            File.Delete(CoachPictureFolder + "\\" + coachList[indexOfCoach].FullNameAndID + fileType);

            string from, to;
            for (int i = indexOfCoach; i < studentList.Count; i++)
            {

                from = CoachPictureFolder + "\\" + coachList[i].FullNameAndID + fileType;
                coachList[i].ID--;
                to = CoachPictureFolder + "\\" + coachList[i].FullNameAndID + fileType;
                RenameFileName(from, to);
            }
            this.Save();
        }

        /// <summary>
        /// Replaces a Student at the specified index with the specified parameter.
        /// </summary>
        /// <param name="indexOfStudent">Specifies ate which index the replacement will occur.</param>
        /// <param name="student">The Student object which will replace the current object.</param>
        /// <param name="picture">The picture of the Student.</param>
        public void ReplaceStudent(int indexOfStudent, Student student, Image picture)
        {
            if (indexOfStudent > studentList.Count - 1 || indexOfStudent < 0)
                throw new IndexOutOfRangeException();

            File.Delete(StudentPicturesFolder + "\\" + studentList[indexOfStudent].FullNameAndID + fileType);

            studentList[indexOfStudent] = student;
            this.Save();
            string filePath = StudentPicturesFolder + "\\" + student.FullNameAndID + fileType;
            Tennis_Management_Software.Imaging.ImageHandling.SaveImage(picture, filePath, System.Drawing.Imaging.ImageFormat.Png);
        }

        /// <summary>
        /// Replaces a Coach at the specified index with the specified parameter.
        /// </summary>
        /// <param name="indexOfCoach">Specifies ate which index the replacement will occur.</param>
        /// <param name="coach">The Coach object which will replace the current object.</param>
        /// <param name="picture">The picture of the Coach</param>
        public void ReplaceCoach(int indexOfCoach, Coach coach, Image picture)
        {
            if (indexOfCoach > coachList.Count - 1 || indexOfCoach < 0)
                throw new IndexOutOfRangeException();

            File.Delete(CoachPictureFolder + "\\" + coachList[indexOfCoach].FullNameAndID + fileType);

            coachList[indexOfCoach] = coach;
            this.Save();
            string filePath = CoachPictureFolder + "\\" + coach.FullNameAndID + fileType;
            Tennis_Management_Software.Imaging.ImageHandling.SaveImage(picture, filePath, System.Drawing.Imaging.ImageFormat.Png);
        }

        /// <summary>
        /// Returns the total money gained from semi-private lesson.
        /// </summary>
        /// <returns></returns>
        public float GetMoneyGainedFromSemiPrivateLessons()
        {
            float moneyGained = 0;
            if (studentList.Count > 0)
            {
                foreach (Student student in studentList)
                {
                    moneyGained += student.GetMoneyPayingForSemiPrivateLessons(lesson_Fees.SemiPrivateFee);
                }
            }
            return moneyGained;
        }

        /// <summary>
        /// Returns the total money gained from private lessons.
        /// </summary>
        /// <returns></returns>
        public float GetMoneyGainedFromPrivateLessons()
        {
            float moneyGained = 0;
            if (studentList.Count > 0)
            {
                foreach (Student student in studentList)
                {
                    moneyGained += student.GetMoneyPayingForPrivateLessons(lesson_Fees.PrivateFee);
                }
            }
            return moneyGained;
        }

        /// <summary>
        /// Returns the total money gained from group lessons.
        /// </summary>
        /// <returns></returns>
        public float GetMoneyGainedFromGroupLessons()
        {
            float moneyGained = 0;
            if (studentList.Count > 0)
            {
                foreach (Student student in studentList)
                {
                    moneyGained += student.GetMoneyPayingForGroupLessons(lesson_Fees.GroupFee);
                }
            }
            return moneyGained;
        }

        /// <summary>
        /// Returns the total money gained from all type of lessons.
        /// </summary>
        /// <returns></returns>
        public float GetMoneyGainedFromLessons()
        {
            float[] moneyGained = new float[3];
            moneyGained[0] = GetMoneyGainedFromGroupLessons();
            moneyGained[1] = GetMoneyGainedFromPrivateLessons();
            moneyGained[2] = GetMoneyGainedFromSemiPrivateLessons();

            return moneyGained.Sum();
        }

        /// <summary>
        /// Returns the total money that the coaches are paid.
        /// </summary>
        /// <returns></returns>
        public float GetMoneyLostForCoaches()
        {
            float moneyLost = 0;
            if (coachList.Count > 0)
            {
                foreach (Coach coach in coachList)
                {
                    moneyLost += coach.GetMoneyPaidThisMonth();
                }
            }
            return moneyLost;
        }

        /// <summary>
        /// Returns the total profit.
        /// </summary>
        /// <returns></returns>
        public float GetTotalProfit()
        {
            return GetMoneyGainedFromLessons() - GetMoneyLostForCoaches();
        }

        /// <summary>
        /// Returns the number of total number of private lessons.
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfPrivateLessons()
        {
            int num = 0;

            if(studentList.Count > 0)
            {
                foreach(Student student in studentList)
                {
                    num += student.TennisPlayerInfo.NumOfPrivateLessonsPerWeek;
                }
            }

            return num;
        }

        /// <summary>
        /// Returns the number of total number of group lessons.
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfGroupLessons()
        {
            int num = 0;

            if (studentList.Count > 0)
            {
                foreach (Student student in studentList)
                {
                    num += student.TennisPlayerInfo.NumOfGroupLessonsPerWeek;
                }
            }

            return num;
        }

        /// <summary>
        /// Returns the number of total number of semi-private lessons.
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfSemiPrivateLessons()
        {
            int num = 0;

            if (studentList.Count > 0)
            {
                foreach (Student student in studentList)
                {
                    num += student.TennisPlayerInfo.NumOfSemiPrivateLessonsPerWeek;
                }
            }

            return num;
        }

        /// <summary>
        /// Creates a folder if it does not already exist.
        /// </summary>
        /// <param name="folderPath"></param>
        private void CreateFolderIfNotExist(string folderPath)
        {
            if (!File.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
        }

        /// <summary>
        /// Renames the name of a file.
        /// </summary>
        private void RenameFileName(string from, string to)
        {
            if (File.Exists(from))
                File.Move(from, to);
        }
    }
}
