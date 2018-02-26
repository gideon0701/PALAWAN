using System;
using System.Collections.Generic;
using System.Linq;


namespace POS1.Model
{
    interface IModel
    {
        string USERNAME { get; set; }
        string PASSWORD { get; set; }
        int validateLogin();
        bool validateInputs();
    }
}
