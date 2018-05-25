﻿using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class BookDAO
    {
        private static BookDAO instance;

        public static BookDAO Instance
        {
            get
            {
                if (instance == null) instance = new BookDAO(); return instance;
            }
            set => instance = value;
        }
        private BookDAO() { }

        public DataTable LoadListBook()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC  USP_LoadListBook");
            return data;
        }

        public bool AddBook(string name, int idCategory, string author, int count, int price)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_AddBook @name , @idCategory , @author , @priceIn , @count",new object[] {name,idCategory,author,price,count }) > 0;
        }
        public bool RemoveBookByBookID(int id)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_RemoveBookByBookID @id",new object[] { id }) > 0;
        }
        public bool UpdateBook(int id, string name, int idCategory, string author, int count, float price)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateBook @id , @name , @idCategory , @author , @count , @priceIn ",new object[] {id,name,idCategory,author,count,price }) > 0;
        }
        public List<Book> GetListBook()
        {
            List<Book> list = new List<Book>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBook");
            foreach(DataRow item in data.Rows)
            {
                list.Add(new Book(item));
            }
            return list;
        }
        public Book GetBookByBookID(int id)
        {
            DataTable data= DataProvider.Instance.ExecuteQuery("USP_GetBookByBookID @id",new object[] { id });
            foreach(DataRow item in data.Rows)
            {
                return new Book(item);
            }
            return null;
        }

        public List<Book>SearchBookByName(string name)
        {
            List<Book> list = new List<Book>();
            DataTable data= DataProvider.Instance.ExecuteQuery(String.Format("SELECT * FROM Book WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name));
            foreach(DataRow item in data.Rows)
            {
                list.Add(new Book(item));
            }
            return list;
        }
        public List<Book>SearchBookByAuthor(string author)
        {
            List<Book> list = new List<Book>();
            DataTable data = DataProvider.Instance.ExecuteQuery(String.Format("SELECT * FROM Book WHERE author=N'"+author+"'"));
            foreach(DataRow item in data.Rows)
            {
                list.Add(new Book(item));
            }
            return list;
        }
        public List<int> GetListBookID()
        {
            List<int> list = new List<int>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBookID");
            foreach(DataRow item in data.Rows)
            {
                list.Add((int)item[0]);
            }
            return list;
        }
       
    }
}