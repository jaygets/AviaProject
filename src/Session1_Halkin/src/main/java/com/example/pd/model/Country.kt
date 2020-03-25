package com.example.pd.model

import androidx.room.Entity
import androidx.room.PrimaryKey

@Entity
data class Country (
    @PrimaryKey(autoGenerate = true)
    val id: Int,
    val name: String
)