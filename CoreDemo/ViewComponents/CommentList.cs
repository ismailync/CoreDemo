using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    UserName = "İsmail"
                },
                 new UserComment
                {
                    ID = 2,
                    UserName = "Hasan"
                },
                  new UserComment
                {
                    ID = 3,
                    UserName = "Ali"
                },
                   new UserComment
                {
                    ID = 4,
                    UserName = "Mert"
                }
            };
            return View(commentvalues);
        }
    }
}
