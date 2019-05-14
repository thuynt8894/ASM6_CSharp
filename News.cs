namespace ConsoleApplication1.ASM6
using System;
using System.Collections.Generic;
using System.Text;
{
    public class News : INews
    {
        private int id;
        private String title;
        private String publishDate;
        private String author;
        private String content;
        public float AverageRate;
        public int[] RateList = new int[3];
        

        public int ID
        {
            get { return this.ID;}
            set { this.ID = value; }
        }

        public string Title
        {
            get { return this.title;}
            set { this.title = value; }
        }

        public string PublishDate
        {
            get { return this.publishDate; }
            set { this.publishDate = value; }
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public string Content
        {
            get { return this.content; }
            set { this.content = value; }
        }

        public News(int id, String title, String publishDate, String author, String content, int[] RateList)
        {

            this.ID = id;
            this.Title = title;
            this.PublishDate = publishDate;
            this.Author = author;
            this.Content = content;
            this.RateList = rateList;

        }
        
        public News()
        {}
        
        public void Display()
        {
            Console.WriteLine("Title"+this.Title+"PublishDate:"+this.PublishDate+"Author"+this.Author+"Content"+this.Content+"AverageRate"+this.AverageRate);
        }

        public void Calculate()
        {
            int sum = 0;
            foreach (int Rate  in RateList)
            {
                sum += Rate;
            }

            AverageRate = (float) sum / RateList.Length;
        }
    }
}