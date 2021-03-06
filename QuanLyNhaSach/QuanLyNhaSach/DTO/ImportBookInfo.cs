﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class ImportBookInfo
    {
        private int iDImportBook;
        private int iDBook;
        private int count;
        private float priceIn;

        public int IDImportBook { get => iDImportBook; set => iDImportBook = value; }
        public int IDBook { get => iDBook; set => iDBook = value; }
        public int Count { get => count; set => count = value; }
        public float PriceIn { get => priceIn; set => priceIn = value; }

        public ImportBookInfo(int idImportBook,int idBook,int count,int price)
        {
            this.IDImportBook = idImportBook;
            this.IDBook = idBook;
            this.Count = count;
            this.PriceIn = price;
        }
        public ImportBookInfo(DataRow row)
        {
            this.IDImportBook = Int32.Parse(row["idImportBook"].ToString());
            this.IDBook = Int32.Parse(row["idBook"].ToString());
            this.Count = Int32.Parse(row["count"].ToString());
            this.PriceIn = (float)Double.Parse(row["priceIn"].ToString());
        }
    }
}
