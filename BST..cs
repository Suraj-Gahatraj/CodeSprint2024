
void Main()
{
	
}


public class Node
{
	public Node left;
	public Node right;
	public int data;
	public Node(int data)
	{
		this.data=data;
	}
}

public class BST
{
	Node root;
	public BST()
	{
		root=null;
	}
	
	public void Insert(int data)
	{
		root=InsertRecursive(root,data);
	}
	
	public Node InsertRecursive(Node root,int data)
	{
		if(root==null)
		return new Node(data);
		
		if(data<root.data)
		{
			return InsertRecursive(root.left,data);
		}
		
		if(data>root.data)
		{
			return InsertRecursive(root.right,data);
		}
		
		return root;
	}

}