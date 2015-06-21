﻿using QLBH_MVC.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unilever.DTO.Entity;

namespace Unilever.DAO
{
    class StaffDAO
    {
        public bool Add(Staff staff)
        {
            using (UnileverEntities entity = new UnileverEntities())
            {
                entity.Staffs.Add(staff);
                entity.SaveChanges();

                return true;
            }
        }

        public bool Remove(int id)
        {
            bool flag = true;

            using (UnileverEntities entity = new UnileverEntities())
            {
                var staff = entity.Staffs.Where(c => c.Id == id).FirstOrDefault();
                if (staff != null)
                {
                    if (staff.Permission != 0)
                    {
                        flag = false;
                    }
                    else
                    {
                        entity.Staffs.Remove(staff);
                        entity.SaveChanges();
                    }
                }
                else
                {
                    flag = false;
                }
            }

            return flag;
        }

        public bool IsExistAccount(String username)
        {
            using (UnileverEntities entity = new UnileverEntities())
            {
                if (entity.Staffs.Where(c => c.Username.Equals(username)).Any())
                {
                    return true;
                }
            }

            return false;
        }

        public bool Login(String username, String password)
        {
            using (UnileverEntities entity = new UnileverEntities())
            {
                String encryptedPwd = MD5Encrypt.Encrypt(password);
                if (entity.Staffs.Where(c => c.Username.Equals(username) && c.Password.Equals(password)).Any())
                {
                    return true;
                }
            }

            return false;
        }

        public Boolean UpdateInfo(Staff staff)
        {
            bool flag = true;

            using (UnileverEntities entity = new UnileverEntities())
            {
                var staffData = entity.Staffs.Where(c => c.Id == staff.Id).FirstOrDefault();
                if (staffData != null)
                {
                    staffData.Name = staff.Name;
                    staffData.Address = staff.Address;
                    staffData.Email = staff.Email;

                    entity.SaveChanges();
                }
                else
                {
                    flag = false;
                }
            }

            return flag;
        }

        public bool UpdatePassword(int id, String oldPwd, String newPwd)
        {
            String encNewPwd = MD5Encrypt.Encrypt(newPwd);
            String encOldPwd = MD5Encrypt.Encrypt(oldPwd);
            bool flag = true;

            using (UnileverEntities entity = new UnileverEntities())
            {
                var acc = entity.Staffs.Where(c => c.Id == id).FirstOrDefault();
                if (acc != null)
                {
                    if (acc.Password.Equals(encOldPwd) == false)
                    {
                        flag = false;
                    }
                    else
                    {
                        acc.Password = encNewPwd;
                    }
                }
                else
                {
                    flag = false;
                }
            }

            return flag;
        }



    }
}
