<div align="left" style="position: relative;">
<h1>FINGERPRINT-TCP-GENERATOR</h1>
<p align="left">
	<img src="https://img.shields.io/github/last-commit/fizkultprivet322/fingerprint-tcp-generator?style=default&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/fizkultprivet322/fingerprint-tcp-generator?style=default&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/fizkultprivet322/fingerprint-tcp-generator?style=default&color=0080ff" alt="repo-language-count">
</p>
<p align="left"><!-- default option, no dependency badges. -->
</p>
<p align="left">
	<!-- default option, no dependency badges. -->
</p>
</div>
<br clear="right">

## 🔗 Table of Contents

- [📍 Overview](#-overview)
- [👾 Features](#-features)
- [📁 Project Structure](#-project-structure)
  - [📂 Project Index](#-project-index)
- [🚀 Getting Started](#-getting-started)
  - [☑️ Prerequisites](#-prerequisites)
  - [⚙️ Installation](#-installation)
  - [🤖 Usage](#🤖-usage)
  - [🧪 Testing](#🧪-testing)
- [📌 Project Roadmap](#-project-roadmap)
- [🔰 Contributing](#-contributing)
- [🎗 License](#-license)
- [🙌 Acknowledgments](#-acknowledgments)

---

## 📍 Overview

<p>This project implements a system for generating JA3 and JA4 fingerprints based on TLS connection parameters, enabling the identification of unique client configurations in a networked environment. The core functionality involves establishing secure TLS connections, extracting relevant cryptographic details such as the protocol version and cipher suites, and utilizing these parameters to generate MD5-based fingerprints. The system supports both JA3 and JA4 fingerprinting schemes, with JA3 focusing on basic connection parameters and JA4 extending this to include additional details like extensions and QUIC parameters.</p>

---

## 👾 Features

- **TLS Protocol Support**: Supports the retrieval and analysis of TLS parameters for different versions (TLS 1.2, TLS 1.3).
- **JA3 Fingerprint Generation**: Generates JA3 fingerprints based on TLS version and cipher suites.
- **JA4 Fingerprint Generation**: Generates JA4 fingerprints, extending JA3 with additional parameters such as extensions and QUIC parameters.
- **TLS Parameter Extraction**: Extracts cipher suites and TLS protocol information using `SslStream` from the .NET library.
- **Error Handling**: Handles connection errors gracefully and provides meaningful error messages for failed TLS connections.
- **Customizability**: Allows injecting custom `SslStreamWrapper` for flexible handling of SSL stream operations.
- **MD5 Hashing**: Utilizes MD5 hashing for generating fingerprints from TLS parameters.
- **Api Integration**: Enables the creation of custom TCP requests based on JA3/JA4 fingerprints, offering advanced integration and testing capabilities.
---

## 📁 Project Structure

```sh
└── fingerprint-tcp-generator/
    ├── Ja34ToTCP
    │   ├── Exceptions
    │   ├── FingerprintGenerator
    │   ├── Ja34ToTCP.csproj
    │   ├── Program.cs
    │   ├── TlsConnection
    │   └── Utils
    ├── Ja34ToTCP.sln
    ├── README.md
    ├── Tests
    │   ├── ConnectionTests.cs
    │   ├── Ja3GeneratorTests.cs
    │   ├── Md5HashingTests.cs
    │   └── Tests.csproj
    └── global.json
```


### 📂 Project Index
<details open>
	<summary><b><code>FINGERPRINT-TCP-GENERATOR/</code></b></summary>
	<details> <!-- __root__ Submodule -->
		<summary><b>__root__</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/master/global.json'>global.json</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/master/Ja34ToTCP.sln'>Ja34ToTCP.sln</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			</table>
		</blockquote>
	</details>
	<details> <!-- Ja34ToTCP Submodule -->
		<summary><b>Ja34ToTCP</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/master/Ja34ToTCP/Program.cs'>Program.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/master/Ja34ToTCP/Ja34ToTCP.csproj'>Ja34ToTCP.csproj</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			</table>
			<details>
				<summary><b>Exceptions</b></summary>
				<blockquote>
					<table>
					<tr>
						<td><b><a href='https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/master/Ja34ToTCP/Exceptions/TlsConnectionException.cs'>TlsConnectionException.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					</table>
				</blockquote>
			</details>
			<details>
				<summary><b>Utils</b></summary>
				<blockquote>
					<table>
					<tr>
						<td><b><a href='https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/master/Ja34ToTCP/Utils/Md5Hashing.cs'>Md5Hashing.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					</table>
				</blockquote>
			</details>
			<details>
				<summary><b>TlsConnection</b></summary>
				<blockquote>
					<table>
					<tr>
						<td><b><a href='https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/master/Ja34ToTCP/TlsConnection/ISslStreamWrapper.cs'>ISslStreamWrapper.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/master/Ja34ToTCP/TlsConnection/Connection.cs'>Connection.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/master/Ja34ToTCP/TlsConnection/SslStreamWrapper.cs'>SslStreamWrapper.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					</table>
				</blockquote>
			</details>
			<details>
				<summary><b>FingerprintGenerator</b></summary>
				<blockquote>
					<table>
					<tr>
						<td><b><a href='https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/master/Ja34ToTCP/FingerprintGenerator/Ja4Generator.cs'>Ja4Generator.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/master/Ja34ToTCP/FingerprintGenerator/Ja3Generator.cs'>Ja3Generator.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					</table>
				</blockquote>
			</details>
		</blockquote>
	</details>
	<details> <!-- Tests Submodule -->
		<summary><b>Tests</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/master/Tests/Ja3GeneratorTests.cs'>Ja3GeneratorTests.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/master/Tests/Tests.csproj'>Tests.csproj</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/master/Tests/Md5HashingTests.cs'>Md5HashingTests.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/master/Tests/ConnectionTests.cs'>ConnectionTests.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			</table>
		</blockquote>
	</details>
</details>

---
## 🚀 Getting Started

### ☑️ Prerequisites

Before getting started with fingerprint-tcp-generator, ensure your runtime environment meets the following requirements:

- **Programming Language:** CSharp
- **Package Manager:** Nuget


### ⚙️ Installation

Install fingerprint-tcp-generator using one of the following methods:

**Build from source:**

1. Clone the fingerprint-tcp-generator repository:
```sh
❯ git clone https://github.com/fizkultprivet322/fingerprint-tcp-generator
```

2. Navigate to the project directory:
```sh
❯ cd fingerprint-tcp-generator
```

3. Install the project dependencies:


**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet restore
```




### 🤖 Usage
Run fingerprint-tcp-generator using the following command:
**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet run
```


### 🧪 Testing
Run the test suite using the following command:
**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet test
```


---
## 📌 Project Roadmap

- [X] **`Task 1`**: <strike>Make exceptions better</strike>
- [X] **`Task 2`**: Add api calls
- [ ] **`Task 3`**: Use web-servers to test, instead of Moq

---

## 🔰 Contributing

- **💬 [Join the Discussions](https://github.com/fizkultprivet322/fingerprint-tcp-generator/discussions)**: Share your insights, provide feedback, or ask questions.
- **🐛 [Report Issues](https://github.com/fizkultprivet322/fingerprint-tcp-generator/issues)**: Submit bugs found or log feature requests for the `fingerprint-tcp-generator` project.
- **💡 [Submit Pull Requests](https://github.com/fizkultprivet322/fingerprint-tcp-generator/blob/main/CONTRIBUTING.md)**: Review open PRs, and submit your own PRs.

<details closed>
<summary>Contributing Guidelines</summary>

1. **Fork the Repository**: Start by forking the project repository to your github account.
2. **Clone Locally**: Clone the forked repository to your local machine using a git client.
   ```sh
   git clone https://github.com/fizkultprivet322/fingerprint-tcp-generator
   ```
3. **Create a New Branch**: Always work on a new branch, giving it a descriptive name.
   ```sh
   git checkout -b new-feature-x
   ```
4. **Make Your Changes**: Develop and test your changes locally.
5. **Commit Your Changes**: Commit with a clear message describing your updates.
   ```sh
   git commit -m 'Implemented new feature x.'
   ```
6. **Push to github**: Push the changes to your forked repository.
   ```sh
   git push origin new-feature-x
   ```
7. **Submit a Pull Request**: Create a PR against the original project repository. Clearly describe the changes and their motivations.
8. **Review**: Once your PR is reviewed and approved, it will be merged into the main branch. Congratulations on your contribution!
</details>

<details closed>
<summary>Contributor Graph</summary>
<br>
<p align="left">
   <a href="https://github.com{/fizkultprivet322/fingerprint-tcp-generator/}graphs/contributors">
      <img src="https://contrib.rocks/image?repo=fizkultprivet322/fingerprint-tcp-generator">
   </a>
</p>
</details>

---

## 🎗 License

This project is protected under the [MIT LICENSE](https://choosealicense.com/licenses/mit/) License. For more details, refer to the [LICENSE](https://github.com/fizkultprivet322/fingerprint-tcp-generator?tab=MIT-1-ov-file#readme) file.

---

## 🙌 Acknowledgments

- [Main Knowledge Base](https://engineering.salesforce.com/tls-fingerprinting-with-ja3-and-ja3s-247362855967/)
- [Ja3 Knowledge Base](https://github.com/salesforce/ja3)
---
