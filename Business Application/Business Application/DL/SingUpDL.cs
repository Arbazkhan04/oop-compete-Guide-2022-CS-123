﻿using Business_Application.BL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business_Application.DL
{
    public class SingUpDL
    {
        public static List<SingUp> userList=new List<SingUp>();

        public static void adddUSerIntoUserLsit(SingUp user)
        {
            userList.Add(user);
        }

        public static bool isAdminAlreadyResitered(SingUp user)
        {
            int count = 0;

            foreach(SingUp users in  userList)
            {
                if(users.getRole()==user.getRole())
                {
                    count++;
                }
            }
           return count >= 1 ? true : false;
        }

        public static bool userExist(userLogin lUser) //check user exist
        {
            foreach(SingUp user in userList)
            {
                if(user.getName()==lUser.name && user.getPassword()==lUser.pasword && user.getRole()==lUser.role)
                {
                    return true;
                }
            }
            return false;
        }

       public static void storeLoginDataIntoTheFile()
        {
            String path = "Auth.txt";
            StreamWriter file = new StreamWriter(path, false);
            foreach(SingUp user in userList)
            {
              file.WriteLine(user.getName() + "," + user.getPassword()+ "," + user.getRole());
            }
            file.Flush();
            file.Close();
        }

        public static void laodLoginDataFromFile()
        {
                String path = "Auth.txt";
                if (File.Exists(path))
                {
                    StreamReader file = new StreamReader(path);
                    String record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] data = record.Split(',');
                    if(data.Length>=3)
                    {
                    SingUp user = new SingUp(data[0], data[1], data[2]);
                    userList.Add(user);
                    }
                }
                   
                    file.Close();
                }
                else
                {
                    Console.Write("Path not exist ");
                }

        }
        
    }
}
