package com.example.pd

import android.app.Application
import androidx.room.Room
import com.example.pd.repository.AppDatabase

class App : Application() {
    private lateinit var appDatabase: AppDatabase
    override fun onCreate() {
        super.onCreate()
        instance = this
        appDatabase = Room
            .databaseBuilder<AppDatabase>(this, AppDatabase::class.java, "database")
            .allowMainThreadQueries()
            .build()
    }
fun getDatabase(): AppDatabase = appDatabase
companion object{
    lateinit var instance:App
}
}