﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace CodeHelper.DataBaseHelper.EF.StorageModels
{
    public class Association :EFBaseNode
    {
        public string Name { get; set; }

        public Dictionary<string, End> Ends = new Dictionary<string, End>();
        public ReferentialConstraint ReferentialConstraint { get; set; }

        public override void Parse(System.Xml.XmlNode dom)
        {

            this.Name = dom.Attributes["Name"].Value;

            foreach (XmlNode n in dom.ChildNodes)
            {
                if (n.Name == "End")
                {
                    var end = new End();
                    end.Parse(n);
                    end.Parent = this;
                    this.Ends.Add(end.Role, end);
                }
                else if (n.Name == "ReferentialConstraint")
                {
                    var referentialConstraint = new ReferentialConstraint();
                    referentialConstraint.Parse(n);
                    referentialConstraint.Parent = this;
                    this.ReferentialConstraint = referentialConstraint;
                }
            }

            base.Parse(dom);
        }

        public class End : EFBaseNode
        {
            public string Type { get; set; }
            public string Role { get; set; }
            public string Multiplicity { get; set; }

            public override void Parse(XmlNode dom)
            {
                this.Type = dom.Attributes["Type"].Value;
                this.Role = dom.Attributes["Role"].Value;
                this.Multiplicity = dom.Attributes["Multiplicity"].Value;


                base.Parse(dom);
            }
        }
    }
}
