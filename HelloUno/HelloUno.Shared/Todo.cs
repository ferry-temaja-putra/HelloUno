using MvvmHelpers;
using System;

namespace HelloUno
{
    public class Todo : ObservableObject
    {
        private string _todoId;

        public string TodoId 
        {
            get => _todoId;
            set => SetProperty(ref _todoId, value);
        }

        private DateTime _createDate;

        public DateTime CreatedDate
        {
            get => _createDate;
            set => SetProperty(ref _createDate, value);
        }

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private bool _done;

        public bool Done
        {
            get => _done;
            set => SetProperty(ref _done, value);
        }
    }
}
