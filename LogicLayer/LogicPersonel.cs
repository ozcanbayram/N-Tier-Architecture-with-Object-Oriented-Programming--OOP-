﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DalPersonel.PersonelLİstesi();
        }
        public static int LLPersonelEkle(EntityPersonel p)
        {
            if (p.Ad != "" && p.Soyad != "" && p.Ad.Length >= 3)
            {
                return DalPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLPersonelSil(int per)
        {
            if (per >= 1)
            {
                return DalPersonel.PersonelSil(per);
            }
            else
            {
                return false;
            }
        }
        public static bool LLPersonelGuncelle(EntityPersonel ent)
        {
            if (ent.Ad.Length >= 4 && ent.Ad != "")
            {
                return DalPersonel.PersonelGuncelle(ent);
            }
            else
            {
                return false;
            }
        }
    }
}
