/* Hidden stub code will pass a root argument to the function below. Complete the function to solve the challenge. Hint: you may want to write one or more helper functions.  

The Node struct is defined as follows:
	struct Node {
		int data;
		Node* left;
		Node* right;
	}
*/
bool checkBST(Node *root)
{
	return isBST(root, 0, 10000);
}

bool isBST(Node *current, int min, int max)
{
	if (current == nullptr)
		return true;

	auto tmp = current->data;
	if (tmp <= min || tmp >= max)
		return false;

	return isBST(current->left, min, current->data ) && isBST(current->right, current->data, max);
}