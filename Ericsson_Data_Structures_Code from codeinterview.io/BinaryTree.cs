//Binary Tree
//https://codeinterview.io/WKQOETRGPR
using System;

public class Test
{
  public static void Main()
  {
    Console.WriteLine("Hello");
    BynaryTree tree = new BynaryTree(1);
    tree.root.left = new Node(2);
    
   Node node4= tree.root.left.left = new Node(4);
    tree.root.left.right = new Node(5);
    
    node4.left=new Node(6);
     node4.right=new Node(7);
    
    tree.root.right= new Node(3);
    
    Console.WriteLine("Pre order");    
    tree.PreOrder(tree.root);
     Console.WriteLine("");
     Console.WriteLine("Post order");
     tree.PostOrder(tree.root);
    Console.WriteLine("");
     Console.WriteLine("In order");
     tree.InOrder(tree.root);
    
    
     BynaryTree tree2 = new BynaryTree(10);
    tree2.root.left = new Node (11);
    tree2.root.right = new Node (12);
   Node mergedtree= tree.MergeTwoBynaryTree(tree.root,tree2.root);
    
     Console.WriteLine("");
     Console.WriteLine("after merge pre order");    
  
    tree.PreOrder(mergedtree);
    
    // both the nodes are null
     Console.WriteLine("");
     Console.WriteLine("null condtion check");    
    Node null1 = null;
    Node null2 = null;
     Node mergedtree1= tree.MergeTwoBynaryTree(null1,null2);
    tree.PreOrder(mergedtree1);
  }
}

public class BynaryTree
{
 public Node root;
  
  public BynaryTree(int data)
  {
    root = new Node(data);
  }
  public BynaryTree()
  {
    root = null;
  }
  
  public void PreOrder(Node node)
  {
    if(node ==null)
      return;
    Console.Write(node.data + " ");
    PreOrder( node.left);
    PreOrder( node.right);
  }
  
  public void InOrder(Node node)
  {
     if(node ==null)
      return;
     InOrder(node.left);
    Console.Write(node.data + " ");
    InOrder(node.right);
  }
  public void PostOrder(Node node)
  {
     if(node ==null)
      return;
      
    PostOrder(node.left);
    PostOrder( node.right);
    Console.Write(node.data + " ");
    
  }
  public Node MergeTwoBynaryTree(Node node1, Node node2)
  {
    if (node1==null)
      return node2;
    if(node2 == null)
      return node1;
    
    node1.data += node2.data;
    node1.left= MergeTwoBynaryTree(node1.left,node2.left);
    node1.right= MergeTwoBynaryTree(node1.right,node2.right);
    return node1;
  }
 
}

public class Node
{
  public int data;
  public Node left;
  public  Node right;
  public Node( int _data)
  {
    data=_data;  
  }
}

