# Define a function to calculate shipping cost
def calculate_shipping():
    print("Welcome to Package Express. Please follow the instructions below.")

    # Prompt for weight
    weight = float(input("Weight of package: "))

    if weight > 50:
        print("Package too heavy to be shipped via Package Express. Have a good day.")
        return

    # Prompt for dimensions
    width = float(input("Width of package: "))
    height = float(input("Height of package: "))
    length = float(input("Length of package: "))

    # Check combined dimensions
    if (width + height + length) > 50:
        print("Package too big to be shipped via Package Express.")
        return

    # Perform cost calculation
    cost = (width * height * length * weight) / 100

    # Output result
    print(f"Your estimated shipping cost is: ${cost:.2f}")
    print("Thank you for choosing Package Express.")

# Run the function
calculate_shipping()
