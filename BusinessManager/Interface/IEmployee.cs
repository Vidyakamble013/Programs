using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.Interface
{
    public interface IEmployee
    {
        IEnumerable<ModalClass> GetAllEmpployee();
        
    }
}
