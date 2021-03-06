﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    //Class for reading (selecting) information from the database
    public class MathWizDA
    {
        readonly static SqlConnection conn = MathWizConn.GetMathWizConnection();


        public static Int64 GetLastInsertedRecord(string tablename, string fieldname)
        {  Int64 aNumber = 0;

            string query = "Select id from tests where id = (select max(id) from tests)"; //"Select @fieldname from @tablename where @fieldname =(select max(@fieldname) from @tablename)"; 
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@tablename", tablename);
            selectCommand.Parameters.AddWithValue("@fieldname", fieldname);

            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                if(reader.Read() && reader.HasRows)
                {
                    aNumber = reader.GetInt32(0); //Convert.ToInt64(reader[""]);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            return aNumber;

        }
           
            
        
    //Begin Find Users Methods - used for finding out which type of user is logging in
    public static bool FindUsername(string username) //Find out if a username has already been taken in any of the user tables
        {
            string query = "SELECT Username FROM admins WHERE Username = @username " +
                     "UNION SELECT Username FROM teachers WHERE Username = @username " +
                     "UNION SELECT Username FROM parents WHERE Username = @username " +
                     "UNION SELECT Username FROM students WHERE Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@username", username);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read() && reader.HasRows) //if true, this means that it found a record with the username
                {
                    reader.Close();
                    conn.Close();
                    return true;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return false;
        }

        public static bool FindPlacementTest(int klassID) 
        {
            string query = "SELECT KlassID FROM tests WHERE KlassID = @klassID " +
                           "AND TestType = 'Placement Test'";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@klassID", klassID);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read() && reader.HasRows) 
                {
                    reader.Close();
                    conn.Close();
                    return true;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return false;
        }

        public static bool FindMasteryTest(int klassID)
        {
            string query = "SELECT KlassID FROM tests WHERE KlassID = @klassID " +
                           "AND TestType = 'Mastery Test'";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@klassID", klassID);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read() && reader.HasRows)
                {
                    reader.Close();
                    conn.Close();
                    return true;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return false;
        }

        public static string FindUserType(string username)
        {
            string userType = "";

            string query = "SELECT 'admin' FROM admins WHERE Username = @username " +
                     "UNION SELECT 'teacher' FROM teachers WHERE Username = @username " +
                     "UNION SELECT 'parent' FROM parents WHERE Username = @username " +
                     "UNION SELECT 'student' FROM students WHERE Username = @username ";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@Username", username);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read() && reader.HasRows)
                {
                    userType = Convert.ToString(reader[""]);
                }
                else //could not find that username in any of the 4 tables
                {
                    userType = "none";
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return userType;
        }

        //SELECT Password - still untested
        public static string SelectPasswordHash(string username)
        {
            string passwordHash = "";

            string query = "SELECT PasswordHash FROM admins WHERE Username = @username " +
                     "UNION SELECT PasswordHash FROM teachers WHERE Username = @username " +
                     "UNION SELECT PasswordHash FROM parents WHERE Username = @username " +
                     "UNION SELECT PasswordHash FROM students WHERE Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@username", username);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    passwordHash = Convert.ToString(reader["PasswordHash"]);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return passwordHash;
        }
    

        //Begin SELECT Single Users Methods
        public static Admin SelectAdmin(string username)
        {
            
            Admin admin = new Admin();
            
            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM admins Where Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@username", username);

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    admin.Id = Convert.ToInt32(reader["Id"]);
                    admin.Username = Convert.ToString(reader["Username"]);
                    admin.FirstName = Convert.ToString(reader["FirstName"]);
                    admin.LastName = Convert.ToString(reader["LastName"]);
                }
                reader.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if(conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return admin;
        }

        public static Teacher SelectTeacher(string username)
        {
            Teacher teacher = new Teacher();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM teachers Where Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@username", username);

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    teacher.Id = Convert.ToInt32(reader["Id"]);
                    teacher.Username = Convert.ToString(reader["Username"]);
                    teacher.FirstName = Convert.ToString(reader["FirstName"]);
                    teacher.LastName = Convert.ToString(reader["LastName"]);
                    
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return teacher;
        }

        public static Student SelectStudent(string username)
        {
            
            Student student = new Student();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM students Where Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@username", username);

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.Username = Convert.ToString(reader["Username"]);
                    student.FirstName = Convert.ToString(reader["FirstName"]);
                    student.LastName = Convert.ToString(reader["LastName"]);
                    student.MasteryLevel = Convert.ToInt32(reader["MasteryLevel"]);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return student;
        }

        public static Parent SelectParent(string username)
        {
            
            Parent parent = new Parent();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM parents Where Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@username", username);

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    parent.Id = Convert.ToInt32(reader["Id"]);
                    parent.Username = Convert.ToString(reader["Username"]);
                    parent.FirstName = Convert.ToString(reader["FirstName"]);
                    parent.LastName = Convert.ToString(reader["LastName"]);
                    parent.Id = Convert.ToInt32(reader["Id"]);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return parent;
        }

        public static List<Student> SelectStudentsViaParent(int parentID)
        {
            List<Student> students = new List<Student>();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM students WHERE ParentID = @ParentID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@ParentID", parentID);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Student student = new Student();
                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.Username = Convert.ToString(reader["Username"]);
                    student.FirstName = Convert.ToString(reader["FirstName"]);
                    student.LastName = Convert.ToString(reader["LastName"]);
                    student.MasteryLevel = Convert.ToInt32(reader["MasteryLevel"]);

                    students.Add(student);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return students;
        }

        public static Klass SelectStudentsKlass(int studentID)
        {
            Klass klass = new Klass();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM klasses k join students s on k.Id=s.KlassID WHERE s.Id = @studentID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@studentID", studentID);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    klass.Id = Convert.ToInt32(reader["KlassID"]);
                    klass.KlassName = Convert.ToString(reader["KlassName"]);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return klass;
        }
        //End SELECT Single Users Methods

        //Begin SELECT ALL Users Methods
        public static List<Admin> SelectAllAdmins()
        {
            List<Admin> admins = new List<Admin>();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM admins";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            
            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Admin admin = new Admin();
                    admin.Id = Convert.ToInt32(reader["Id"]);
                    admin.Username = Convert.ToString(reader["Username"]);
                    admin.FirstName = Convert.ToString(reader["FirstName"]);
                    admin.LastName = Convert.ToString(reader["LastName"]);

                    admins.Add(admin);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return admins;
        }

        public static List<Teacher> SelectAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM teachers";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            
            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                
                while (reader.Read())
                {
                    Teacher teacher = new Teacher();
                    teacher.Id = Convert.ToInt32(reader["Id"]);
                    teacher.Username = Convert.ToString(reader["Username"]);
                    teacher.FirstName = Convert.ToString(reader["FirstName"]);
                    teacher.LastName = Convert.ToString(reader["LastName"]);

                    teachers.Add(teacher);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return teachers;
        }

        public static List<Parent> SelectAllParents()
        {
            List<Parent> parents = new List<Parent>();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM parents";
            SqlCommand selectCommand = new SqlCommand(query, conn);

            
            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                
                while (reader.Read()) 
                {
                    Parent parent = new Parent();
                    parent.Id = Convert.ToInt32(reader["Id"]);
                    parent.Username = Convert.ToString(reader["Username"]);
                    parent.FirstName = Convert.ToString(reader["FirstName"]);
                    parent.LastName = Convert.ToString(reader["LastName"]);

                    parents.Add(parent);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return parents;
        }

        public static List<Student> SelectAllStudents()
        {
            List<Student> students = new List<Student>();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM students";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            
            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                
                while (reader.Read())
                {
                    Student student = new Student();
                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.Username = Convert.ToString(reader["Username"]);
                    student.FirstName = Convert.ToString(reader["FirstName"]);
                    student.LastName = Convert.ToString(reader["LastName"]);
                    student.MasteryLevel = Convert.ToInt32(reader["MasteryLevel"]);

                    students.Add(student);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return students;
        }

        //End SELECT ALL Users Methods

        public static PlacementTest SelectKlassesPlacementTest(int klassID)
        {
            PlacementTest placementTest = new PlacementTest();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM tests WHERE KlassID = @klassID AND TestType = 'Placement Test'";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@klassID", klassID);
            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    placementTest.Id = Convert.ToInt32(reader["Id"]);
                    placementTest.TimeLimit = TimeSpan.ParseExact(reader["TimeLimit"].ToString(), "hh\\:mm\\:ss", CultureInfo.InvariantCulture);
                    placementTest.RandomlyGenerated = Convert.ToBoolean(reader["RandomlyGenerated"]);
                    placementTest.MinLevel = Convert.ToInt32(reader["MinLevel"]);
                    placementTest.MaxLevel = Convert.ToInt32(reader["MaxLevel"]);
                }
                reader.Close();
                
                placementTest.Questions = SelectQuestions(placementTest.Id);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return placementTest;
        }

        public static List<MasteryTest> SelectKlassesMasteryTests(int klassID)
        {
            List<MasteryTest> masteryTests = new List<MasteryTest>();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM tests WHERE KlassID = @klassID AND TestType = 'Mastery Test'";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@klassID", klassID);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    MasteryTest masteryTest = new MasteryTest();

                    masteryTest.Id = Convert.ToInt32(reader["Id"]);
                    masteryTest.TimeLimit = TimeSpan.ParseExact(reader["TimeLimit"].ToString(), "hh\\:mm\\:ss", CultureInfo.InvariantCulture);
                    masteryTest.RandomlyGenerated = Convert.ToBoolean(reader["RandomlyGenerated"]);
                    masteryTest.MasteryLevel = Convert.ToInt32(reader["MinLevel"]);
                    
                    masteryTests.Add(masteryTest);
                }
                reader.Close();

                foreach(MasteryTest m in masteryTests) //add the questions to the test objects
                {
                    m.Questions = SelectQuestions(m.Id);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return masteryTests;
        }

        public static List<Question> SelectQuestions(int testID)
        {
            List<Question> questions = new List<Question>();
            
            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM questions WHERE TestID = @testID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@testID", testID);
            
            try
            {
                if (conn != null && conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read()) 
                {
                    Question question = new Question();

                    question.Id = Convert.ToInt32(reader["Id"]);
                    question.MasteryLevel = Convert.ToInt16(reader["MasteryLevel"]);
                    question.QuestionText = Convert.ToString(reader["QuestionText"]);
                    question.CorrectAnswer = Convert.ToInt16(reader["CorrectAnswer"]);
                    question.TimeLimit = TimeSpan.ParseExact(reader["TimeLimit"].ToString(), "hh\\:mm\\:ss", CultureInfo.InvariantCulture);
                    question.Weight = Convert.ToInt16(reader["Weight"]);
                    question.RandomlyGenerated = Convert.ToBoolean(reader["RandomlyGenerated"]);

                    questions.Add(question);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return questions;
        }
        
        public static GradedQuestion SelectGradeQuestion(int id)
        {
            
            GradedQuestion gradeQuestion = new GradedQuestion();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM GradedQuestions WHERE ID = @ID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@BranchName", id);

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    gradeQuestion.Id = Convert.ToInt32(reader["QuestionID"]);
                    gradeQuestion.StudentAnswer = Convert.ToString(reader["StudentAnswer"]);
                    gradeQuestion.Correct = Convert.ToBoolean(reader["Correct"]);
                    gradeQuestion.TimeTakenToAnswer = TimeSpan.Parse(reader["TimeTakenToAnswer"].ToString());
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return gradeQuestion;
        }

        public static Klass SelectKlass(int klassID)
        {
            
            Klass klass = new Klass();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM Klasses WHERE Id = @ID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@Id", klassID);

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    klass.Id = Convert.ToInt32(reader["Id"]);
                    klass.KlassName = Convert.ToString(reader["KlassName"]);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return klass;
        }

        public static List<Student> SelectAllStudentsInKlass(int klassID)
        {
            List<Student> students = new List<Student>();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM students WHERE KlassID = @klassID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@klassID", klassID);

            try
            {
                if (conn == null || conn.State == ConnectionState.Closed) //only open the connection if it is not open already to prevent crash
                {
                    conn.Open();
                }
                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Student student = new Student();
                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.Username = Convert.ToString(reader["Username"]);
                    student.FirstName = Convert.ToString(reader["FirstName"]);
                    student.LastName = Convert.ToString(reader["LastName"]);
                    student.MasteryLevel = Convert.ToInt32(reader["MasteryLevel"]);

                    students.Add(student);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return students;
        }

        public static List<Klass> SelectAllKlasses()
        {
            List<Klass> klasses = new List<Klass>();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM klasses";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            
            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                Klass klass = new Klass();

                while (reader.Read())
                {
                    klass = new Klass();
                    klass.Id = Convert.ToInt32(reader["Id"]);
                    klass.KlassName = Convert.ToString(reader["KlassName"]);
                    klasses.Add(klass);
                }
                reader.Close();

                klass.Students = SelectAllStudentsInKlass(klass.Id);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return klasses;
        }

        public static List<Klass> SelectAllKlassesByTeacher(int teacherID)
        {
            List<Klass> klasses = new List<Klass>();

            //This is not safe!!!
            string query = $"SELECT * FROM klasses where TeacherID = @teacherID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@teacherID", teacherID);

            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                Klass klass = new Klass();

                while (reader.Read())
                {
                    klass = new Klass();
                    klass.Id = Convert.ToInt32(reader["Id"]);
                    klass.KlassName = Convert.ToString(reader["KlassName"]);
                    klasses.Add(klass);
                }
                reader.Close();

                foreach(var k in klasses)
                {
                    k.Students = SelectAllStudentsInKlass(klass.Id);
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return klasses;
        }

        public static int SelectGradedTestIDViaTestID(int testID)
        {

            int gradedTestID = 0;

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT Id FROM graded_tests WHERE TestID = @testID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@TestID", testID);


            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    gradedTestID = Convert.ToInt32(reader["Id"]);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return gradedTestID;
        }

    }

}
