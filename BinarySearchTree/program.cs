/* Hidden stub code will pass a root argument to the function below. Complete the function to solve the challenge. Hint: you may want to write one or more helper functions.  

The Node struct is defined as follows:
	struct Node {
		int data;
		Node* left;
		Node* right;
	}
*/
	bool checkBST(Node* root)
    {
        auto leftNode = root->left;
		if(leftNode != nullptr)
        {
            if(leftNode->data > root->data)
            {
                return false;
            }
            if(!checkBST(leftNode))
            return false;
        }
        leftNode  = root->right;
        if(leftNode != nullptr)
        {
            if(leftNode->data < root->data)
            {
                return false;
            }
            if(!checkBST(leftNode))
            return false;
        }
        return true;
	}