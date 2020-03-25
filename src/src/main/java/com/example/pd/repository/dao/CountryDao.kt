package com.example.pd.repository.dao

import androidx.room.*
import com.example.pd.model.Country

@Dao
interface CountryDao {
    @Query("SELECT * FROM Country")
    fun getAll(): List<Country>

    @Query("SELECT * FROM Country WHERE id=:id")
    fun getById(id: Int): Country?

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    fun insert(country: Country)

    @Delete
    fun delete(country: Country)
}