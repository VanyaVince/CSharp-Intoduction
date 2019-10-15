using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class FileCheck : ICheck
    {
        private readonly string _path;

        public FileCheck(String path)
        {
            this._path = path;
        }
        public bool IfExist(String nickName)
        {
            foreach (var item in DeserializedListOfUser())
            {
                if (item.Login == nickName)
                    return true;
            }
            return false;
        }

        public void Record(User user)
        {
            List<User> users = DeserializedListOfUser();

            users.Add(user);

            using (StreamWriter file = new StreamWriter(this._path))
            {
                string json =  JsonConvert.SerializeObject(users.ToArray());
                file.Write(json);
            }
        }

        private List<User> DeserializedListOfUser()
        {
            if (File.Exists(this._path))
            {
                using (StreamReader stream = new StreamReader(this._path))
                {
                    string json = stream.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<User>>(json);

                    return items;
                }
            }

            return new List<User>();
        } 
    }
}