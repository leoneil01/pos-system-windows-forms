﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Remoting;

namespace Odrunia_POS_System.Components
{
	internal class Value
	{
		// Server Values
		public string serverName = "localhost";
		public string serverUser = "root1";
		public string serverPass = "";
		public string serverPort = "3306";
		public string serverDb = "odrunia_pos_db";

		//User Role Values
		public static int userRoleId;
		public int UserRoleId { get { return userRoleId; } set { userRoleId = value; } }

		public static string userRole;
		public string UserRole { get { return userRole; } set { userRole = value; } }

		// Gender Values
		public static int genderId;
		public int GenderId { get { return genderId; } set { genderId = value; } }

		public static string gender;
		public string Gender { get { return gender; } set { gender = value; } }

		// My Values
		public static int myId;
		public int MyId { get { return myId; } set { myId = value; } }

		public static byte[] myProfilePicture;
		public byte[] MyProfilePicture { get { return myProfilePicture; } set { myProfilePicture = value; } }

		public static string myUserRole;
		public string MyUserRole { get { return myUserRole; } set { myUserRole = value; } }

		public static string myFirstName;
		public string MyFirstName { get { return myFirstName; } set { myFirstName = value; } }

		public static string myMiddleName;
		public string MyMiddleName { get { return myMiddleName; } set { myMiddleName = value; } }

		public static string myLastName;
		public string MyLastName { get { return myLastName; } set { myLastName = value; } }

		public static string myGender;
		public string MyGender { get { return myGender; } set { myGender = value; } }

		public static int myAge;
		public int MyAge { get { return myAge; } set { myAge = value; } }

		public static DateTime myBirthday;
		public DateTime MyBirthday { get { return myBirthday; } set { myBirthday = value; } }

		public static string myContactNumber;
		public string MyContactNumber { get { return myContactNumber; } set { myContactNumber = value; } }

		public static string myEmail;
		public string MyEmail { get { return myEmail; } set { myEmail = value; } }

		public static string myUsername;
		public string MyUsername { get { return myUsername; } set { myUsername = value; } }

		public string MyFullName
		{
			get
			{
				if(String.IsNullOrWhiteSpace(myMiddleName))
				{
					return string.Format("{0} {1}", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myFirstName), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myLastName));
				}
				else
				{
					return string.Format("{0} {1}. {2}", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myFirstName), myMiddleName[0].ToString().ToUpper(), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myLastName));
				}
			}
		}

		// User Values
		public static int userId;
		public int UserId { get { return userId; } set { userId = value; } }

		public static byte[] userProfilePicture;
		public byte[] UserProfilePicture { get { return userProfilePicture; } set { userProfilePicture = value; } }

		public static string userUserRole;
		public string UserUserRole { get { return userUserRole; } set { userUserRole = value; } }

		public static string userFirstName;
		public string UserFirstName { get { return userFirstName; } set { userFirstName = value; } }

		public static string userMiddleName;
		public string UserMiddleName { get { return userMiddleName; } set { userMiddleName = value; } }

		public static string userLastName;
		public string UserLastName { get { return userLastName; } set { userLastName = value; } }

		public static string userGender;
		public string UserGender { get { return userGender; } set { userGender = value; } }

		public static int userAge;
		public int UserAge { get { return userAge; } set { userAge = value; } }

		public static DateTime userBirthday;
		public DateTime UserBirthday { get { return userBirthday; } set { userBirthday = value; } }

		public static string userContactNumber;
		public string UserContactNumber { get { return userContactNumber; } set { userContactNumber = value; } }

		public static string userEmail;
		public string UserEmail { get { return userEmail; } set { userEmail = value; } }

		public static string userUsername;
		public string UserUsername { get { return userUsername; } set { userUsername = value; } }

		// Product Values
		public static byte[] productProfile;
        public byte[] ProductProfile { get { return productProfile; } set { productProfile = value; } }

        public static int productId;
		public int ProductId { get { return productId; } set { productId = value; } }

		public static byte[] productImg;
        public byte[] ProductImg { get { return productImg; } set { productImg = value; } }

        public static string productCode;
		public string ProductCode { get { return productCode; } set { productCode = value; } }

		public static string productName;
		public string ProductName { get { return productName; } set { productName = value; } }

		public static double productPrice;
		public double ProductPrice { get { return productPrice; } set { productPrice = value; } }

		public static int productQuantity;
		public int ProductQuantity { get { return productQuantity; } set { productQuantity = value; } }

		public static DateTime productCreated;
		public DateTime ProductCreated { get { return productCreated; } set { productCreated = value; } }

		public static DateTime productUpdated;
		public DateTime ProductUpdated { get { return productUpdated; } set { productUpdated = value; } }
	}

	internal class Cart
	{
		// Customer Values
		public string ProductCode { get; set; }
		public string ProductName { get; set; }
		public double ProductPrice { get; set; }
		public int ProductQuantity { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
