// C program to evaluate value of a postfix 
// expression having multiple digit operands 
#include <stdio.h> 
#include <string.h> 
#include <ctype.h> 
#include <stdlib.h> 
#include <math.h>

typedef struct Node
{
	char c;
	struct Node*next;
}Node;
char test(Node**head);
void push(char, Node**);
char pop(Node**);
int empty(Node*);
int FromChar(char* str);// I didn't use this function
char* ToChar(int num);
int ScanNumFromStack(Node** stack);
void PushNumbersToStack(Node** stack, int val);
void create(Node** head);



// The main function that returns value 
// of a given postfix expression 
int evaluatePostfix(char* exp)
{
	
	Node* stack;
	char c;
	int x1, x2,result=0;
	create(&stack);
	for (size_t i = 0; i < strlen(exp); i++)
	{

		c = exp[i];
		switch (c)
		{
		case '+':
			x1 = ScanNumFromStack(&stack);
			x2 = ScanNumFromStack(&stack);
			result = x1 + x2;
			PushNumbersToStack(&stack,result);
			break;

		case '-':
			x1 = ScanNumFromStack(&stack);
			x2 = ScanNumFromStack(&stack);
			result = x2 - x1;
			PushNumbersToStack(&stack, result);
			break;

		case '*':
			x1 = ScanNumFromStack(&stack);
			x2 = ScanNumFromStack(&stack);
			result = x1 * x2;
			PushNumbersToStack(&stack, result);
			break;

		case '/':
			x1 = ScanNumFromStack(&stack);
			x2 = ScanNumFromStack(&stack);
			result = x2 / x1;
			PushNumbersToStack(&stack, result);
			break;

		case '^':
			x2 = ScanNumFromStack(&stack);
			x1 = ScanNumFromStack(&stack);
			result = 1;
			for (size_t i = 0; i < x2; i++)
			{
				result *= x1;
			}
			PushNumbersToStack(&stack, result);
			break;

		default:
			push(c,&stack);
			break;
		}
		

	}
	return ScanNumFromStack(&stack);




}

//---------------------------------------------
void infixTopostfix(char infix[], char postfix[]) {

	Node*head = NULL;
	char ans; int i = 0, j = 0, size, flag = 0;
	size = strlen(infix);
	postfix[j] = ' ';	j++;

	for (i; i < size; i++)
	{

		if (infix[i] == '(')
		{
			push(infix[i], &head);
			flag = 1;
		}
		if (infix[i] == ')')
		{
			ans = pop(&head);
			while ((!empty(head)) && (ans != '('))
			{
				postfix[j] = ans; j++;
				postfix[j] = ' '; j++;
				ans = pop(&head);

			}
			flag = 0;

		}
		if ((infix[i] == '+') || (infix[i] == '*') || (infix[i] == '-') || (infix[i] == '^') || (infix[i] == '/')) {

			if (!empty(head) && flag == 0)
			{
				ans = test(&head);

				if (infix[i] == '*' || infix[i] == '/')
				{
					if (ans != '+' && ans != '-' && ans != '(')
					{
						ans = pop(&head);
						postfix[j] = ans; j++;
						postfix[j] = ' '; j++;

					}



				}
				if (infix[i] == '^')
				{
					if (ans != '+' && ans != '-' && ans != '*' && ans != '/' && ans != '(')
					{
						ans = pop(&head);
						postfix[j] = ans; j++;
						postfix[j] = ' '; j++;

					}



				}

				if (infix[i] == '+' || infix[i] == '-')
				{
					ans = pop(&head);
					postfix[j] = ans; j++;
					postfix[j] = ' '; j++;

				}
			}

			push(infix[i], &head);



		}
		if (('0' <= infix[i]) && (infix[i] <= '9'))
		{
			while (('0' <= infix[i]) && (infix[i] <= '9'))
			{
				postfix[j] = infix[i];
				j++;
				i++;
			}
			i--;

			postfix[j] = ' ';
			j++;

		}


	}


	while (!empty(head))
	{
		ans = pop(&head);
		postfix[j] = ans; j++;
		postfix[j] = ' '; j++;



	}
	postfix[j] = '\0';



}




//----------------------------------------------


//----------------------------------------------
void PrintExpDetails(char exp[]) {
	char sol[100] = { 0 };
	infixTopostfix(exp, sol);
	printf("Infix expresion: %s\n", exp);
	printf("Postfix expression: %s\n", sol);
	printf("It's Value: %d\n", evaluatePostfix(sol));
	printf("***********************************\n");
}

//----------------------------------------------
// Driver program to test the above functions 
int main()
{
	
	char ex[][50] = { "10*5-3", "(5-2)*13", "18-3*5", "4*5-2", "(10+3)*2", "20-3*5", "12-12/3", "(7+4)^2",
	"(4*5)^2", "(15-7)-4*(18-30)^2", "(23-2)*2^4" };

	for (int i = 0; i < 11; i++)
    PrintExpDetails(ex[i]);
	






	//printf("%d",evaluatePostfix(" 20 3 5 * -"));
//	evaluatePostfix(" 10 5 +");
	/*
	Node*head = NULL;
	push('a', &head);
	push('b', &head);
	push('c', &head);

	printf("test print \n");

	Node*help = head;
	while (help != NULL)
	{
	printf("%c \n", help->c);
	help = help->next;

	}
	printf("end test passed \n");
	pop(&head);
	help = head;
	while (help != NULL)
	{
	printf("%c \n", help->c);
	help = help->next;

	}

	while (!empty(head))
	pop(&head);

	help = head;
	printf("here \n");
	while (help != NULL)
	{
	printf("%c \n", help->c);
	help = help->next;

	}
	*/
	getchar();
	return 0;
}

//----------------------------------------------


void push(char info, Node**head) {

	Node* p = (Node*)malloc(sizeof(Node));
	p->c = info;
	p->next= *(head);
	*head = p;

}
//----------------------------------------------
char pop(Node**head)
{
	char ans; Node*help;
	if (empty(*head))
		printf("error");
	else
	{
		ans = (*head)->c;
		help = *head;
		*head = help->next;
		free(help);

		return ans;
	};
}
//----------------------------------------------
int empty(Node*head)
{
	if (head == NULL)
		return 1;
	else
		return 0;

}
//----------------------------------------------
int FromChar(char* str)
{
	int i = 0, result = 0;
	while (str[i] != '\0')
	{
		result *= 10;
		result += str[i] - '0';
		i++;
	}
	return result;
};
//----------------------------------------------
void create(Node** head) 
{ 
	*head = NULL;
}
//----------------------------------------------
char* ToChar(int num)
{
	int i = 0, num2 = num;
	while (num2 != 0)
	{
		i++;
		num2 /= 10;
	}
	char* result = (char*)malloc(i*sizeof(char)+1);
	result[i] = '\0';
	for (int j = i-1; j >= 0; j--)
	{
		result[j] = num % 10 + '0';
		num = num / 10;
	}
	return result;
};
//----------------------------------------------
int ScanNumFromStack(Node** stack)
{	
	int result = 0,i = 0;
	char c = pop(stack);
	char num[15];
	while (c == ' ')
	{
		c = pop(stack);

	}
	
	
	while (c != ' ')
	{
		num[i] = c;
		if(!empty(*stack))
			c = pop(stack);
		else c = ' ';
		i++;
	}
	num[i] = '\0';
	for (int j = i-1; j >= 0; j--)
	{
		result *= 10;
		result += num[j] - '0';
	
	}
	push(' ',stack);
	return result;
};
//----------------------------------------------
void PushNumbersToStack(Node** stack, int val)
{
	char* num = ToChar(val);
	while (*num != '\0')
	{
		push(*num, stack);
		num++;
	}
	
};
//----------------------------------------------
char test(Node**head)
{
	if (*head != NULL)
		return (*head)->c;


}