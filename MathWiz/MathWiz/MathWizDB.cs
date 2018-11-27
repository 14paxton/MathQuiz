﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    //Class for inserting, updating, or deleting from the database
    public static class MathWizDB
    {
        readonly static SqlConnection conn = MathWizConn.GetMathWizConnection();

        public static void InsertParent(Parent newParent)
        {
            string insertStatement = "INSERT INTO parents (Username, FirstName, LastName, PasswordHash) " +
                "VALUES(@Username, @FirstName, @LastName, @Password)";
      
            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@Username", newParent.Username);
            Cmd.Parameters.AddWithValue("@FirstName", newParent.FirstName);
            Cmd.Parameters.AddWithValue("@LastName", newParent.LastName);
            Cmd.Parameters.AddWithValue("@Password", newParent.Password);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }
        public static void InsertTestQuestionMastery(MasteryTest test, Question q, Int64 testID)
        {
            string insertStatement = "Insert into questions (testID, MasteryLevel, QuestionText, CorrectAnswer, TimeLimit, RandomlyGenerated) " +
                "Values(@testID, @masteryLevel, @QuestionText, @CorrectAnswer, @TimeLimit, @RandomlyGenerated)";

            SqlCommand cmd = new SqlCommand(insertStatement, conn);
            cmd.Parameters.AddWithValue("@masteryLevel", test.MasteryLevel);
            cmd.Parameters.AddWithValue("@testID", testID);
            cmd.Parameters.AddWithValue("@timeLimit", test.TimeLimit);
            cmd.Parameters.AddWithValue("@RandomlyGenerated", test.RandomlyGenerated);
            cmd.Parameters.AddWithValue("@QuestionText", q.QuestionText);
            cmd.Parameters.AddWithValue("@CorrectAnswer", q.CorrectAnswer.ToString());
            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }
        public static void InsertTestQuestionPlacement(PlacementTest test, Question q, Int64 testID)
        {
            string insertStatement = "Insert into questions (testID, QuestionText, CorrectAnswer, TimeLimit, RandomlyGenerated) " +
                "Values(@testID, @QuestionText, @CorrectAnswer, @TimeLimit, @RandomlyGenerated)";

            SqlCommand cmd = new SqlCommand(insertStatement, conn);
            cmd.Parameters.AddWithValue("@testID", testID);
            cmd.Parameters.AddWithValue("@timeLimit", test.TimeLimit);
            cmd.Parameters.AddWithValue("@RandomlyGenerated", test.RandomlyGenerated);
            cmd.Parameters.AddWithValue("@QuestionText", q.QuestionText);
            cmd.Parameters.AddWithValue("@CorrectAnswer", q.CorrectAnswer.ToString());
            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }
        public static void InsertTestQuestionsPractice(PracticeTest test, Question q, Int64 testID)
        {
            string insertStatement = "Insert into questions (testID, QuestionText, CorrectAnswer, TimeLimit, RandomlyGenerated) " +
                "Values(@testID, @QuestionText, @CorrectAnswer, @TimeLimit, @RandomlyGenerated)";

            SqlCommand cmd = new SqlCommand(insertStatement, conn);
            cmd.Parameters.AddWithValue("@testID", testID);
            cmd.Parameters.AddWithValue("@timeLimit", test.TimeLimit);
            cmd.Parameters.AddWithValue("@RandomlyGenerated", test.RandomlyGenerated);
            cmd.Parameters.AddWithValue("@QuestionText", q.QuestionText);
            cmd.Parameters.AddWithValue("@CorrectAnswer", q.CorrectAnswer.ToString());
            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }
        public static void InsertPracticeTest(PracticeTest test, int klassID)
        {
            string insertStatment = "INSERT INTO TESTS (KlassID, testtype, timelimit, randomlygenerated, minlevel, maxlevel) " +
                "VAlUES(@klassID, @testtype, @timeLimit, @randomlygenerated, @minlevel, @maxlevel)";

            SqlCommand cmd = new SqlCommand(insertStatment, conn);

            cmd.Parameters.AddWithValue("@klassID", klassID);
            cmd.Parameters.AddWithValue("@testtype", "Practice Test");
            cmd.Parameters.AddWithValue("@timelimit", test.TimeLimit);
            cmd.Parameters.AddWithValue("@randomlygenerated", test.RandomlyGenerated);
            cmd.Parameters.AddWithValue("@minlevel", test.MinLevel);
            cmd.Parameters.AddWithValue("@maxlevel", test.MaxLevel);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        internal static void InsertMasteryTest(MasteryTest test, int klassID)
        {
            string insertStatment = "INSERT INTO TESTS (KlassID, testtype, timelimit, randomlygenerated, passthreshhold, masterylevel) " +
                "VAlUES(@klassID, @testtype, @timeLimit, @randomlygenerated, @passthreshhold, @masterylevel)";

            SqlCommand cmd = new SqlCommand(insertStatment, conn);

            cmd.Parameters.AddWithValue("@klassID", klassID);
            cmd.Parameters.AddWithValue("@testtype", "Mastery Test");
            cmd.Parameters.AddWithValue("@timelimit", test.TimeLimit);
            cmd.Parameters.AddWithValue("@randomlygenerated", test.RandomlyGenerated);
            cmd.Parameters.AddWithValue("@passthreshhold", test.PassThreshhold);
            cmd.Parameters.AddWithValue("@masterylevel", value:test.MasteryLevel);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        internal static void InsertPlacementTest(PlacementTest test, int klassID)
        {
            string insertStatment = "INSERT INTO TESTS (KlassID, testtype, timelimit, randomlygenerated, minlevel, maxlevel) " +
                "VAlUES(@klassID, @testtype, @timeLimit, @randomlygenerated, @minlevel, @maxlevel)";

            SqlCommand cmd = new SqlCommand(insertStatment, conn);

            cmd.Parameters.AddWithValue("@klassID", klassID);
            cmd.Parameters.AddWithValue("@testtype", "Placement Test");
            cmd.Parameters.AddWithValue("@timelimit", test.TimeLimit);
            cmd.Parameters.AddWithValue("@randomlygenerated", test.RandomlyGenerated);
            cmd.Parameters.AddWithValue("@minlevel", test.MinLevel);
            cmd.Parameters.AddWithValue("@maxlevel", test.MaxLevel);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void InsertStudent(Student newStudent, int parentID, int klassID)
        {
            string insertStatement = "INSERT INTO students (ParentID, KlassID, Username, FirstName, LastName, PasswordHash) " +
                "VALUES(@ParentID, @KlassID, @Username, @FirstName, @LastName, @Password)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@ParentID", parentID);
            Cmd.Parameters.AddWithValue("@KlassID", klassID);
            Cmd.Parameters.AddWithValue("@Username", newStudent.Username);
            Cmd.Parameters.AddWithValue("@FirstName", newStudent.FirstName);
            Cmd.Parameters.AddWithValue("@LastName", newStudent.LastName);
            Cmd.Parameters.AddWithValue("@Password", newStudent.Password);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }

        public static void InsertTeacher(Teacher newTeacher)
        {
            string insertStatement = "INSERT INTO teachers (Username, FirstName, LastName, PasswordHash) " +
                "VALUES(@Username, @FirstName, @LastName, @Password)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@Username", newTeacher.Username);
            Cmd.Parameters.AddWithValue("@FirstName", newTeacher.FirstName);
            Cmd.Parameters.AddWithValue("@LastName", newTeacher.LastName);
            Cmd.Parameters.AddWithValue("@Password", newTeacher.Password);

            try
            {
                conn.Open();
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }

        public static void InsertAdmin(Admin newAdmin)
        {
            string insertStatement = "INSERT INTO admins (Username, FirstName, LastName, PasswordHash) " +
                "VALUES(@Username, @FirstName, @LastName, @Password)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@Username", newAdmin.Username);
            Cmd.Parameters.AddWithValue("@FirstName", newAdmin.FirstName);
            Cmd.Parameters.AddWithValue("@LastName", newAdmin.LastName);
            Cmd.Parameters.AddWithValue("@Password", newAdmin.Password);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }

        public static void InsertQuestion(Question newQuestion, int testID)
        {
            string insertStatement = "INSERT INTO questions (TestID, MasteryLevel, QuestionText, CorrectAnswer, TimeLimit, Weight, RandomlyGenerated) " +
                "VALUES(@TestID, @MasteryLevel, @QuestionText, @CorrectAnswer, @TimeLimit, @Weight, @RNG)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@TestID", testID);
            Cmd.Parameters.AddWithValue("@MasteryLevel", newQuestion.MasteryLevel);
            Cmd.Parameters.AddWithValue("@QuestionText", newQuestion.QuestionText);
            Cmd.Parameters.AddWithValue("@CorrectAnswer", newQuestion.CorrectAnswer);
            Cmd.Parameters.AddWithValue("@TimeLimit", newQuestion.TimeLimit);
            Cmd.Parameters.AddWithValue("@Weight", newQuestion.Weight);
            Cmd.Parameters.AddWithValue("@RNG", newQuestion.RandomlyGenerated);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }

        public static void InsertKlass(Klass newKlass, int teacherID)
        {
            string insertStatement = "INSERT INTO klasses (TeacherID, KlassName) " +
                "VALUES(@TeacherID, @KlassName)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@TeacherID", teacherID);
            Cmd.Parameters.AddWithValue("@KlassName", newKlass.KlassName);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }

        public static void InsertTest(Test newTest, string testType, decimal passThreshold, int minLevel, int maxLevel)
        {
            //Everything besides TestType can be null
            string insertStatement = "INSERT INTO tests (TestType, TimeLimit, RandomlyGenerated, PassThreshHold, MinLevel, MaxLevel) " +
                "VALUES(@Type, @TimeLimit, @RNG, @PassThreshold, @MinLevel, @MaxLevel)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@Type", testType);
            Cmd.Parameters.AddWithValue("@TimeLimit", newTest.TimeLimit);
            Cmd.Parameters.AddWithValue("@RNG", newTest.RandomlyGenerated);
            Cmd.Parameters.AddWithValue("@PassThreshold", passThreshold);
            Cmd.Parameters.AddWithValue("@MinLevel", minLevel);
            Cmd.Parameters.AddWithValue("@MaxLevel", maxLevel);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }

        public static void InsertGradedQuestion(GradedQuestion newQuestion, int questionID, int gradedTestID)
        {
            string insertStatement = "INSERT INTO graded_questions (GradedTestID, QuestionID, StudentAnswer, Correct, TimeTakenToAnswer) " +
                "VALUES(@TestID, @QuestionID, @StudentAnswer, @Correct, @Time)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@TestID", gradedTestID);
            Cmd.Parameters.AddWithValue("@QuestionID", questionID);
            Cmd.Parameters.AddWithValue("@StudentAnswer", newQuestion.StudentAnswer);
            Cmd.Parameters.AddWithValue("@Correct", newQuestion.Correct);
            Cmd.Parameters.AddWithValue("@Time", newQuestion.TimeTakenToAnswer);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }

        //Kevin - I think that this one can be much simpler. First off it needs specific kind of graded test I think. All the other ones I perfect!
        public static void InsertGradedTest(GradedTest newTest, int studentID, int testID, int attempts, byte passed, int recommendedLevel)
        {
            // StudentID, TestID, and Score must be present
            // Everything else can be null
            string insertStatement = "INSERT INTO graded_tests (StudentID, TestID, Score, TimeTakenToComplete, DateTaken, Feedback, NumberAttempts, Passed, RecommendedLevel) " +
                "VALUES(@StudentID, @TestID, @Score, @Time, @DateTaken, @Feedback, @Attempts, @Passed, @RecommendLevel)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@StudentID", studentID);
            Cmd.Parameters.AddWithValue("@TestID", testID);
            Cmd.Parameters.AddWithValue("@Score", newTest.Score);
            Cmd.Parameters.AddWithValue("@Time", newTest.TimeTakenToComplete);
            Cmd.Parameters.AddWithValue("@DateTaken", newTest.DateTaken);
            Cmd.Parameters.AddWithValue("@Feedback", newTest.Feedback);
            Cmd.Parameters.AddWithValue("@Attempts", attempts);
            Cmd.Parameters.AddWithValue("@Passed", passed);
            Cmd.Parameters.AddWithValue("@RecommendLevel", recommendedLevel);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }
        public static void UpdatePassword(string userType, string username, string passwordHash)
        {
            string insertStatement = "";

            switch (userType) //need this case structure because you can't bind values to a table name, and I want to do it the safe way without {}
            {
                case "admin":
                    insertStatement = "UPDATE admins ";
                    break;

                case "teacher":
                    insertStatement = "UPDATE teachers ";
                    break;

                case "parent":
                    insertStatement = "UPDATE parents ";
                    break;

                case "student":
                    insertStatement = "UPDATE students ";
                    break;

            }

            insertStatement += "SET PasswordHash = @passwordHash WHERE Username = @username";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);
            Cmd.Parameters.AddWithValue("@username", username);
            Cmd.Parameters.AddWithValue("@passwordHash", passwordHash);
            
            try
            {
                conn.Open();
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeleteUser(string userType, int id, string username) //very important to get this command and security right
        {
            string insertStatement = "";

            switch (userType) //need this case structure because you can't bind values to a table name, and I want to do it the safe way without {}
            {
                case "admin":
                    insertStatement = "DELETE FROM admins ";
                    break;

                case "teacher":
                    insertStatement = "DELETE FROM teachers ";
                    break;

                case "parent":
                    insertStatement = "DELETE FROM parents ";
                    break;

                case "student":
                    insertStatement = "DELETE FROM students ";
                    break;
            }

            insertStatement += "Where Id = @id AND Username = @username"; //Keep this WHERE statement here at all costs!!!
            
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);
            Cmd.Parameters.AddWithValue("@id", id);
            Cmd.Parameters.AddWithValue("@username", username);

            try
            {
                conn.Open();
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeleteGradedTest(int studentID)
        {
            string deleteStatement = "DELETE FROM graded_tests WHERE StudentID = @studentID";
            SqlCommand Cmd = new SqlCommand(deleteStatement, conn);
            Cmd.Parameters.AddWithValue("@studentID", studentID);
            try
            {
                conn.Open();
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeleteGradedQuestions(int gradedTestID)
        {
            string deleteStatement = "DELETE FROM graded_questions WHERE GradedTestID = @gradedTestID";
            SqlCommand Cmd = new SqlCommand(deleteStatement, conn);
            Cmd.Parameters.AddWithValue("@gradedTestID", gradedTestID);
            try
            {
                conn.Open();
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
