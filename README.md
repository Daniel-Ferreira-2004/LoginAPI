# LoginAPI
# 🔐 LoginAPI – ASP.NET Core MVC

Aplicação desenvolvida em **ASP.NET Core MVC** utilizando **ASP.NET Identity** para **autenticação e gerenciamento de usuários**. O projeto implementa cadastro, login, logout e alteração de senha com **segurança baseada em Identity e cookies**, seguindo boas práticas de backend em .NET.

---

## 🚀 Funcionalidades

* Cadastro de usuários
* Login com validação de credenciais
* Logout
* Alteração de senha
* Validações de formulário
* Hash e armazenamento seguro de senhas (ASP.NET Identity)
* Autenticação baseada em **cookies**

---

## 🛠️ Tecnologias Utilizadas

* **C#**
* **ASP.NET Core MVC**
* **ASP.NET Identity**
* **Entity Framework Core**
* **SQL Server**
* **Razor Views**

---

## 📂 Estrutura do Projeto

```bash
LoginAPI/
│
├── Controllers/
│   ├── AccountController.cs
│   └── HomeController.cs
│
├── Models/
│   ├── Users.cs
│   └── ErrorViewModel.cs
│
├── ViewModels/
│   ├── LoginViewModel.cs
│   ├── RegisterViewModel.cs
│   └── ChangePasswordViewModel.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── Migrations/
├── Views/
├── Program.cs
└── appsettings.json
```

---

## 🔐 Autenticação e Segurança

A autenticação é realizada com **ASP.NET Identity**, utilizando:

* `UserManager` para criação e gerenciamento de usuários
* `SignInManager` para login e logout
* **Hash automático de senha**
* Autenticação via **cookies** (padrão MVC)

Não há uso de JWT ou autenticação stateless.

---

## ▶️ Como Executar o Projeto

### Pré-requisitos

* .NET SDK 7 ou superior
* SQL Server / SQL Server Express
* Visual Studio ou VS Code

### Passos

```bash
# Clone o repositório
git clone https://github.com/Daniel-Ferreira-2004/LoginAPI.git

# Acesse a pasta
cd LoginAPI

# Restaure os pacotes
dotnet restore

# Atualize o banco de dados
dotnet ef database update

# Execute o projeto
dotnet run
```

A aplicação estará disponível em:

```
https://localhost:5001
```

---

## 🎯 Objetivo do Projeto

Projeto desenvolvido com foco em:

* Aprender **ASP.NET Core MVC**
* Implementar autenticação com **ASP.NET Identity**
* Aplicar boas práticas de backend
* Compor portfólio para **vaga júnior .NET**

---

## 👨‍💻 Autor

**Daniel Ferreira**

* GitHub: [@Daniel-Ferreira-2004](https://github.com/Daniel-Ferreira-2004)

---

⭐ Se este projeto te ajudou ou serviu como referência, deixe uma estrela!
