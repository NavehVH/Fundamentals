package structures;

public class MyStack {
    private int[] arr;
    private int top;

    private static final int CAPACITY = 1000;

    public MyStack() {
        this.arr = new int[CAPACITY];
        this.top = -1;
    }

    public boolean isEmpty() {
        return this.top == -1;
    }

    public void push(int val) {
        if (top >= CAPACITY - 1) {
            throw new IllegalStateException("Stack is at max capacity.");
        }
        this.arr[++top] = val;
    }

    public int peek() {
        if (this.isEmpty()) {
            throw new IllegalStateException("Empty Stack.");
        }
        return this.arr[top];
    }

    public int pop() {
        if (this.isEmpty()) {
            throw new IllegalStateException("Already Empty Stack.");
        }
        return this.arr[top--];
    }
}
