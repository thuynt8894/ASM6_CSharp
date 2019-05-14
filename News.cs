namespace ConsoleApplication1.ASM6
using System;
using System.Collections.Generic;
using System.Text;
{
    public class News : INews
    {
        private int ID;
        private String Title;
        private String PublishDate;
        private String Author;
        private String Content;
        public float AverageRate;
        public int[] RateList = new int[3];

        public News(int ID, String Title, String PublishDate, String Author, String Content, int[] RateList)
        {
            this.ID = ID;
            this.Title = Title;
            this.PublishDate = PublishDate;
            this.Author = Author;
            this.Content = Content;
            this.RateList = RateList;
        }
        
        public News()
        {}

        public int ID1
        {
            get { return this.ID;}
            set { this.ID = value; }
        }

        public string Title1
        {
            get { return this.Title;}
            set { this.Title = value; }
        }

        public string PublishDate1
        {
            get { return this.PublishDate; }
            set { this.PublishDate = value; }
        }

        public string Author1
        {
            get { return this.Author; }
            set { this.Author = value; }
        }

        public string Content1
        {
            get { return this.Content; }
            set { this.Content = value; }
        }

        public void Display()
        {
            Console.WriteLine(this.getTitle()+"--"+this.getPublishDate()+"--"+this.getAuthor()+ " -- "+this.getContent()+" -- "+this.getAverageRate());
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