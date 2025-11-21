# Python Program using control structures

# Python Program using control structures

def menu():
    print("----- MENU -----")
    print("1. Check if number is even or odd")
    print("2. Print numbers from 1 to N")
    print("3. Calculate factorial of a number")
    print("4. Exit")

while True:
    menu()
    choice = int(input("Enter your choice (1-4): "))

    if choice == 1:
        num = int(input("Enter a number: "))
        if num % 2 == 0:
            print(f"{num} is Even")
        else:
            print(f"{num} is Odd")

    elif choice == 2:
        n = int(input("Enter the value of N: "))
        print("Numbers from 1 to", n)
        for i in range(1, n+1):
            print(i, end=" ")
        print()

    elif choice == 3:
        num = int(input("Enter a number: "))
        fact = 1
        i = 1
        while i <= num:
            fact *= i
            i += 1
        print(f"Factorial of {num} is {fact}")

    elif choice == 4:
        print("Exiting the program. Goodbye!")
        break

    else:
        print("Invalid choice. Please select between 1 to 4.")