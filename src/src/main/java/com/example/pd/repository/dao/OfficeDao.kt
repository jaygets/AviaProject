package com.example.pd.repository.dao

import androidx.room.*
import com.example.pd.model.Office

@Dao
interface OfficeDao {
    @Query("SELECT * FROM Office")
    fun getAll(): List<Office>

    @Query("SELECT * FROM Office WHERE id=:id")
    fun getById(id:Int): Office?

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    fun insert(office: Office)

    @Delete
    fun delete(office: Office)
}