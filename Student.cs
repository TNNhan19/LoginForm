﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPR
{
    class Student
    {
        internal bool insertStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string adrs, MemoryStream pic)
        {
            throw new NotImplementedException();
        }

        class STUDENT
        {
            MY_DB mydb = new MY_DB();

            // function to insert a new student
            public bool insertStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
            {
                SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender, phone, address, picture) " +
                                                    "VALUES (@id, @fn, @ln, @bdt, @gen, @phn, @adrs, @pic)", mydb.getConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@bdt", SqlDbType.Date).Value = bdate;
                command.Parameters.Add("@gen", SqlDbType.VarChar).Value = gender;
                command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
                command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
                command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

                mydb.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    mydb.closeConnection();
                    return true;
                }
                else
                {
                    mydb.closeConnection();
                    return false;
                }
            }
        }

    }
}
