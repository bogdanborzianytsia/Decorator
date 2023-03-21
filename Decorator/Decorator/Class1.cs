using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Tree
    {
        public string Name { get; protected set; }
        public string photo { get; protected set; }
        public Tree(string n, string photo)
        {
            this.Name = n;
            this.photo = photo;
        }
        public abstract int GetYear();
    }

    class YoungTree : Tree
    {
        public YoungTree() : base("Tree1", "Tree.jfif")
        { }
        public override int GetYear()
        {
            return 10;
        }
    }
    class OldTree : Tree
    {
        public OldTree()
            : base("Tree2", "Tree2.jfif")
        { }
        public override int GetYear()
        {
            return 100;
        }
    }

    abstract class TreeDecorator : Tree
    {
        protected Tree tree;
        public TreeDecorator(string n, string g, Tree boats) : base(n, g)
        {
            this.tree = boats;
        }
    }

    class YoungerTree : TreeDecorator
    {
        public YoungerTree(Tree p)
            : base(p.Name + ", Young", p.photo, p)
        { }

        public override int GetYear()
        {
            return tree.GetYear();
        }
    }

    class OlderTree : TreeDecorator
    {
        public OlderTree(Tree p)
            : base(p.Name + ",Old", p.photo, p)
        { }

        public override int GetYear()
        {
            return tree.GetYear() + 400;
        }
    }
}
