using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.Models
{
    public class Task: INotifyPropertyChanged
    {
        string header;
        string description;
        string? filePath;
        
        public string Header
        {
            get
            {
                return this.header;
            }
            set
            {
                this.header = value;
                RaisePropertyChangedEvent("Header");
            }
        }
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
                RaisePropertyChangedEvent("Description");
            }
        }
        public string? FilePath
        {
            get
            {
                return this.filePath;
            }
            set
            {
                this.filePath = value;
                RaisePropertyChangedEvent("FilePath");
            }
        }

        public Task(string header)
        {
            this.Header = header;
        }

        public void UploadFile(string path)
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChangedEvent(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs e = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, e);
            }
        }

    }
}
