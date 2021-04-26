using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeManager.Core.Models
{
    public class ProjectModel
    {
        [Key]
        public int Key { get; set; }
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 评分
        /// </summary>
        public int Scroll { get; set; }
    }
}
