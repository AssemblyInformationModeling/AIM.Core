using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using ICSharpCode.SharpZipLib.Zip;
using Rhino.Geometry;

namespace AIM.Core
{
    public class Writer
    {

        private SQLiteConnection dbConnection;
        private string filePath;
        private string modelName;

        /// <summary>
        /// Create a new Writer
        /// </summary>
        /// <param name="filePath">File Path</param>
        /// <param name="modelName">Model Name</param>
        public Writer(string filePath, string modelName)
        {

            string folderPath = filePath + "/" + modelName;

            // If database exists already
            if (Directory.Exists(folderPath))
            {
                throw new Exception("Folder Exists already!");
            }


            this.filePath = filePath;
            this.modelName = modelName;


            Directory.CreateDirectory(folderPath);

            Directory.CreateDirectory(folderPath + "/geometry");
            Directory.CreateDirectory(folderPath + "/docs");


            dbConnection = new SQLiteConnection("Data Source=" + folderPath + "/data.db;Version=3;");
            dbConnection.Open();

            SQLiteCommand parts_SQL = new SQLiteCommand("CREATE TABLE  Parts  ( ID 	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, EntryPosition TEXT, FinalPosition INTEGER); ", dbConnection);
            parts_SQL.ExecuteNonQuery();
            SQLiteCommand transformations_SQL = new SQLiteCommand("CREATE TABLE  Transformations ( ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,  PartId INTEGER,  type INTEGER,  data 	TEXT); ", dbConnection);
            transformations_SQL.ExecuteNonQuery();
            SQLiteCommand components_SQL = new SQLiteCommand("CREATE TABLE  Components ( ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, PartID INTEGER); ", dbConnection);
            components_SQL.ExecuteNonQuery();
            SQLiteCommand fasteners_SQL = new SQLiteCommand("CREATE TABLE  Fasteners ( ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Type INTEGER, PartID INTEGER, Data TEXT); ", dbConnection);
            fasteners_SQL.ExecuteNonQuery();
            SQLiteCommand fastenersDef_SQL = new SQLiteCommand("CREATE TABLE  FastenersDef  ( ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Name TEXT, Description TEXT, Data 	TEXT); ", dbConnection);
            fastenersDef_SQL.ExecuteNonQuery();
            SQLiteCommand joints_SQL = new SQLiteCommand("CREATE TABLE  Joints  ( ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Type INTEGER, PartID INTEGER, Data 	TEXT); ", dbConnection);
            joints_SQL.ExecuteNonQuery();
            SQLiteCommand jointsDef_SQL = new SQLiteCommand("CREATE TABLE  JointsDef ( ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Name TEXT, Description TEXT, Data 	TEXT); ", dbConnection);
            jointsDef_SQL.ExecuteNonQuery();
            SQLiteCommand issues_SQL = new SQLiteCommand("CREATE TABLE  Issues ( ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, UserID INTEGER, Data TEXT); ", dbConnection);
            issues_SQL.ExecuteNonQuery();

            // Close the database 
            dbConnection.Close();
        }

        /// <summary>
        /// Export Model to .adm file
        /// </summary>
        /// <param name="model"></param>
        public void Export(Model model)
        {

            dbConnection.Open();






            // Issue
            foreach (Issue issue in model.issues)
            {
                int userId = issue.User;
                string data = issue.Data;
                SQLiteCommand newIssue = new SQLiteCommand("insert into Issues (ID, UserID, Data) values (''," + userId.ToString() + ", " + data + ")", dbConnection);
                newIssue.ExecuteNonQuery();
            }

            dbConnection.Close();

        }

    }
}