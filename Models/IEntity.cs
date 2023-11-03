using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonService.DatabaseLayer.Models
{
    public interface IEntity<T>
    {
        public T Id { get; set; }
    }  
     public interface Iproduct
    {
        public string ProductCode { get; set; }
    }  



}
