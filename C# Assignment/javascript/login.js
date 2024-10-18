document.addEventListener("DOMContentLoaded", () => {
    const userForm = document.getElementById("user-form");
    const heading = document.getElementById("form-heading");
    const toggleText = document.getElementById("toggle-text");
    let registrationMode = true;

    toggleText.addEventListener("click", () => {
        registrationMode = !registrationMode;
        heading.textContent = registrationMode ? "Register" : "Sign In";
        userForm.querySelector("button").textContent = registrationMode ? "Register" : "Sign In";
        toggleText.textContent = registrationMode
            ? "Already registered? Sign In"
            : "No account? Sign Up";
    });

    userForm.addEventListener("submit", (event) => {
        event.preventDefault();

        const enteredUsername = document.getElementById("user").value;
        const enteredPassword = document.getElementById("pass").value;

        if (enteredUsername === "" || enteredPassword === "") {
            alert("Both fields are mandatory.");
            return;
        }

        if (registrationMode) {
            // Store user credentials in localStorage
            localStorage.setItem("user", enteredUsername);
            localStorage.setItem("pass", enteredPassword);
            alert("Registration successful! You can now sign in.");
        } else {
            // Check login credentials
            const savedUser = localStorage.getItem("user");
            const savedPass = localStorage.getItem("pass");

            if (enteredUsername === savedUser && enteredPassword === savedPass) {
                alert("Sign In successful!");
            } else {
                alert("Incorrect username or password.");
            }
        }
    });
});
