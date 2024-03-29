﻿using System;
using System.Windows;

namespace CSharp_Chumak4.Views
{

    public partial class CreateEditUserWindow : Window
    {
        public CreateEditUserWindow(Action<User> onRegisterAction, User user = null)
        {
            InitializeComponent();
            DataContext = new UserEditRegisterViewModel(user, delegate (User newUser)
            {
                Close();
                onRegisterAction(newUser);
            });
        }
    }
}
