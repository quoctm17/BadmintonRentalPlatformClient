# 🏸 Badminton Court Booking Platform - Frontend

Welcome to the frontend of the Badminton Court Booking Platform! This project is built using Razor Pages combined with JavaScript. This README file provides an overview of the product, the technologies used, instructions for using GitHub, and important notes for cloning the project.

## 📚 Table of Contents
- [Overview](#overview)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## 🌟 Overview
The Badminton Court Booking Platform frontend is designed to provide an intuitive user interface for booking badminton courts, managing user profiles, and viewing booking history.

## 🛠 Technologies Used
- **Frontend**: Razor Pages, JavaScript
- **Styling**: BoostrapCSS
- **API Integration**: Fetch API / Axios

## 🚀 Getting Started

### Prerequisites
- .NET 6.0 SDK or later
- Node.js (for any JavaScript dependencies)
- Git

### Installation
1. **Clone the repository:**
    ```bash
    git clone https://github.com/quoctm17/BadmintonRentalPlatformClient.git
    ```

2. **Setup:**
    - Install the .NET dependencies:
      ```bash
      dotnet restore
      ```
    - Install any Node.js dependencies if required:
      ```bash
      npm install
      ```
    - Create a `appsettings.Development.json` file and add your backend API URL:
      ```json
      {
        "ApiUrl": "http://localhost:5135"
      }
      ```
    - Run the frontend server:
      ```bash
      dotnet run
      ```

## 📖 Usage
1. Open your browser and navigate to `http://localhost:5142`.
2. Register a new account or log in with existing credentials.
3. View available badminton courts and book your preferred time slots.
4. Manage your bookings from your user dashboard.

## 📝 Contributing
We welcome contributions! Please follow these steps to contribute:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature-name`).
3. Make your changes and commit them (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/your-feature-name`).
5. Create a new Pull Request.

## ⚠️ Important Notes
- Ensure that your development environment meets the prerequisites mentioned above.
- When cloning the project, update the `appsettings.Development.json` file with your local configurations.
- For any issues or feature requests, please open an issue on GitHub.

## 📄 License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

---

Thank you for using the Badminton Court Booking Platform! If you have any questions, feel free to reach out to us.

Happy coding! 🎉
