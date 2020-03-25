package com.example.pd.repository.dao

import androidx.room.*
import com.example.pd.model.Role

@Dao
interface RoleDao {
    @Query("SELECT * FROM Role")
    fun getAll(): List<Role>

    @Query("SELECT * FROM Role WHERE id=:id")
    fun getById(id:Int): Role?

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    fun insert(role: Role)

    @Delete()
    fun delete(role: Role)
}
