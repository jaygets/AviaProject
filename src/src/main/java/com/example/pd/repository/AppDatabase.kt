package com.example.pd.repository

import androidx.room.Database
import androidx.room.RoomDatabase
import com.example.pd.model.Country
import com.example.pd.model.Office
import com.example.pd.model.Role
import com.example.pd.model.User
import com.example.pd.repository.dao.CountryDao
import com.example.pd.repository.dao.OfficeDao
import com.example.pd.repository.dao.RoleDao
import com.example.pd.repository.dao.UserDao

@Database(entities = [Country::class, Office::class, Role::class, User::class],version = 1)
abstract class AppDatabase : RoomDatabase() {
    abstract fun countryDao(): CountryDao
    abstract fun officeDao(): OfficeDao
    abstract fun roleDao(): RoleDao
    abstract fun userDao(): UserDao
}