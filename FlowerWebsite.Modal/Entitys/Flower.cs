﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FlowerWebsite.Model.Entitys
{
    public class Flower
    {
        /// <summary>
        /// 主键
        /// </summary>
      
        public long Id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
     
        public string Title { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
    
        public int Type { get; set; }
        /// <summary>
        /// 列表页图片
        /// </summary>
 
        public string Image { get; set; }
        /// <summary>
        /// 详情页图片
        /// </summary>
      
        public string BigImage { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
    
        public string Description { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
     
        public decimal Price { get; set; }
        /// <summary>
        /// 花语
        /// </summary> 
        public string Language { get; set; }
        /// <summary>
        /// 材质
        /// </summary> 
        public string Material { get; set; }
        /// <summary>
        /// 包装
        /// </summary>
        public string Packing { get; set; }
        /// <summary>
        /// 配送说明
        /// </summary>
        public string DeliveryRemarks { get; set; }

    }
}
