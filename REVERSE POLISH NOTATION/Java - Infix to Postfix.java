import java.util.*;

class InfixToPostfix {

    public static boolean isOperator(char c) {
        return c == '+' || c == '-' || c == '*' || c == '/' || c == '^';
    }

    public static int precedence(char c) {
        if (c == '^') {
            return 3;
        } else if (c == '*' || c == '/') {
            return 2;
        } else if (c == '+' || c == '-') {
            return 1;
        } else {
            return -1;
        }
    }

    public static boolean validateInfix(String infix) {
        int count = 0;
        for (int i = 0; i < infix.length(); i++) {
            char c = infix.charAt(i);
            if (c == '(') {
                count += 1;
            } else if (c == ')') {
                count -= 1;
            }
        }

        if (count != 0) {
            return false;
        }

        if (isOperator(infix.charAt(0)) || isOperator(infix.charAt(infix.length() - 1))) {
            return false;
        }

        for (int i = 0; i < infix.length(); i++) {
            char c = infix.charAt(i);
            if (!isOperator(c) && !Character.isLetterOrDigit(c) && c != ' ') {
                return false;
            }
        }

        return true;
    }

    public static String infixToPostfix(String infix) {
        StringBuilder postfix = new StringBuilder();
        Stack<Character> stack = new Stack<>();
    
        for (int i = 0; i < infix.length(); i++) {
            char c = infix.charAt(i);
    
            if (Character.isLetterOrDigit(c)) {
                postfix.append(c).append(' ');
            } else if (isOperator(c)) {
                while (!stack.isEmpty() && stack.peek() != '(' && precedence(stack.peek()) >= precedence(c)) {
                    postfix.append(stack.pop()).append(' ');
                }
                stack.push(c);
            } else if (c == '(') {
                stack.push(c);
            } else if (c == ')') {
                while (!stack.isEmpty() && stack.peek() != '(') {
                    postfix.append(stack.pop()).append(' ');
                }
                if (!stack.isEmpty() && stack.peek() == '(') {
                    stack.pop();
                }
            }
        }
    
        while (!stack.isEmpty()) {
            postfix.append(stack.pop()).append(' ');
        }
    
        return postfix.toString().trim();
    }
    
    public static double evaluatePostfix(String postfix) {
        Stack<Double> stack = new Stack<>();
    
        String[] tokens = postfix.split(" ");
        for (String token : tokens) {
            if (token.matches("\\d+(\\.\\d+)?")) {
                stack.push(Double.parseDouble(token));
            } else if (isOperator(token.charAt(0))) {
                if (stack.size() < 2) {
                    throw new IllegalArgumentException("Invalid postfix expression");
                }
                double b = stack.pop();
                double a = stack.pop();
                double result = applyOperator(token.charAt(0), a, b);
                stack.push(result);
            } else {
                throw new IllegalArgumentException("Invalid character in postfix expression");
            }
        }
    
        if (stack.size() != 1) {
            throw new IllegalArgumentException("Invalid postfix expression");
        }
    
        return stack.pop();
    }
    
    private static double applyOperator(char op, double a, double b) {
        switch (op) {
            case '+':
                return a + b;
            case '-':
                return a - b;
            case '*':
                return a * b;
            case '/':
               
            if (b == 0) {
                throw new ArithmeticException("Division by zero");
            }
            return a / b;
        case '^':
            return Math.pow(a, b);
        default:
            throw new IllegalArgumentException("Invalid operator");
    }
}

public static void main(String[] args) {
    String infix = "2 + 3 * 4";
    String postfix = infixToPostfix(infix);
    System.out.println("Postfix expression: " + postfix);
    System.out.println("Result: " + evaluatePostfix(postfix));
    System.out.println();

    infix = "2 + 3 * 4 / 5 - 6";
    postfix = infixToPostfix(infix);
    System.out.println("Postfix expression: " + postfix);
    System.out.println("Result: " + evaluatePostfix(postfix));
    System.out.println();

    infix = "2 + 3 * 4 / (5 - 6)";
    postfix = infixToPostfix(infix);
    System.out.println("Postfix expression: " + postfix);
    System.out.println("Result: " + evaluatePostfix(postfix));
    System.out.println();

    infix = "2 + 3 * 4 / (5 - 6) ^ 2";
    postfix = infixToPostfix(infix);
    System.out.println("Postfix expression: " + postfix);
    System.out.println("Result: " + evaluatePostfix(postfix));
    System.out.println();

    infix = "2 + 3 * 4 / (5 - 6) ^ 2 + 3";
    postfix = infixToPostfix(infix);
    System.out.println("Postfix expression: " + postfix);
    System.out.println("Result: " + evaluatePostfix(postfix));
}
}