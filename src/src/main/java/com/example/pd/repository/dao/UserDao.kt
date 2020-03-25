package com.example.pd.repository.dao

import androidx.room.*
import com.example.pd.model.User

@Dao
interface UserDao {
    @Query("SELECT * FROM User")
    fun getAll(): List<User>

    @Query("SELECT * FROM User WHERE id=:id")
    fun getById(id:Int): User?

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    fun insert (user: User)

    @Delete()
    fun delete(user: User)
}