﻿
///=========================================================================
/// 版    权： Coypright 2012 - 2016 @ zhumm(Berton)
/// 文件名称： Person.cs
/// 模版作者： zhumingming(berton) 最后修改于 2016-5-27 16:10:10
/// 作者邮箱： zhumingming1040@163.com,937553351@qq.com
/// 描    述： 单独生成的代码，请在代码生成后手动添加【描述】信息
/// 创 建 人： zhumingming(Berton) (CodeSmith V6.5.0 自动生成的代码 模板V4.0)
/// 创建时间： 2016/5/30 14:58:48
///=========================================================================

using System;
using System.Text;
using MDORM.DapperExt.Mapper;

namespace MDORM.Entity
{
    /// <summary>
    /// Person 实体类,包括:属性，重写的ToString方法
    /// </summary>
    /// 创建人：zhumingming(Berton)
    /// 创建时间：2016/5/30 14:58:48
    [Serializable]
    public class Person
    {
        #region 成员变量
        private int? _id;
        private string _firstName;
        private string _lastName;
        private bool? _active;
        private int? _sex;
        private DateTime? _crteatDate;
        #endregion

        #region 属性
        /// <summary>
        /// Id
        /// </summary>
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        /// <summary>
        /// LastName
        /// </summary>
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        /// <summary>
        /// Active
        /// </summary>
        public bool? Active
        {
            get { return this._active; }
            set { this._active = value; }
        }

        /// <summary>
        /// Sex
        /// </summary>
        public int? Sex
        {
            get { return this._sex; }
            set { this._sex = value; }
        }

        /// <summary>
        /// CrteatDate
        /// </summary>
        public DateTime? CrteatDate
        {
            get { return this._crteatDate; }
            set { this._crteatDate = value; }
        }

        #endregion

        #region 扩展的变量、属性、方法
        /// <summary>
        /// 返回这个对象的JSON格式字符串，方便记录日志
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder temp = new StringBuilder();
            temp.Append("[{ ");
            temp.AppendFormat("\"Id\":\"{0}\", ", this.Id);
            temp.AppendFormat("\"FirstName\":\"{0}\", ", this.FirstName);
            temp.AppendFormat("\"LastName\":\"{0}\", ", this.LastName);
            temp.AppendFormat("\"Active\":\"{0}\", ", this.Active);
            temp.AppendFormat("\"Sex\":\"{0}\", ", this.Sex);
            temp.AppendFormat("\"CrteatDate\":\"{0}\", ", this.CrteatDate);
            int lastPos = temp.ToString().LastIndexOf(',');
            if (lastPos != -1)
                temp = temp.Remove(lastPos, 1);
            temp.Append("}]");
            return temp.ToString();
        }
        #endregion
    }

    /// <summary>
    /// Person 映射类
    /// </summary>
    /// 创建人：朱明明
    /// 创建时间：2016/5/23 15:03:02

    [Serializable]
    public class PersonMapper : ClassMapper<Person>
    {
        /// <summary>
        /// Person Mapper构造函数（可自定义Mapper）
        /// </summary>
        public PersonMapper()
        {
            base.Table("Person");
            Map(f => f.Id).Key(KeyType.Identity);
            AutoMap();
        }
    }
}
