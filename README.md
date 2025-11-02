🔔 FCM Notification Sender – Desktop Application

A C# Desktop Application that allows users to easily generate and send push notifications to mobile devices via Firebase Cloud Messaging (FCM).
This tool is ideal for developers, testers, and administrators who need a simple interface to send and test notifications to Android or iOS apps integrated with Firebase.

------------------------------

🏗️ Overview

The FCM Notification Sender Desktop App simplifies the process of creating and sending Firebase Cloud Messaging (FCM) notifications directly from your desktop.
With a clean UI and robust backend logic, users can quickly compose messages, specify device tokens or topics, and push notifications to FCM servers using their Server Key.

This project demonstrates desktop-to-cloud communication, REST API calls, and JSON payload generation using C#.

-----------------------

🚀 Features
💬 Notification Management

Send notifications to individual devices (by token)

Broadcast to topics or groups

Support for Title, Body, and Custom Data payloads

⚙️ Configuration

Store and manage FCM Server Key and Sender ID

Supports multiple environment profiles (Development, Production)

📦 JSON Payload Builder

Auto-generate properly formatted FCM payloads

Add custom data fields dynamically

📡 FCM Integration

Communicate directly with Firebase FCM REST API

HTTPS-based secure communication

Display success/failure response in real-time

🖥️ User Interface

Desktop UI built with Windows Forms or WPF

Real-time logs and message status tracking

Simple form for notification creation and sending

----------------------

🧱 Technologies Used
| Category            | Technology                            |
| ------------------- | ------------------------------------- |
| **Language**        | C#                                    |
| **Framework**       | .NET 6 / .NET 8                       |
| **UI Framework**    | Windows Forms / WPF                   |
| **API Integration** | Firebase Cloud Messaging (REST API)   |
| **Libraries**       | System.Net.Http.Json, Newtonsoft.Json |
| **Communication**   | HTTPS (POST JSON Payload)             |

----------------------------

5️⃣ Send a Test Notification

Enter Device Token or Topic

Fill Title and Body

(Optional) Add key-value pairs for custom data

Click Send Notification

View response in the console/log panel

--------------------------

🔮 Future Enhancements

Add support for batch notifications (multiple tokens)

Schedule notifications for future delivery

Support image and sound attachments

Add history log export (CSV/JSON)

Implement desktop notification feedback on delivery
