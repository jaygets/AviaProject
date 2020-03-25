package com.example.pd.model

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey

@Entity
data class Role(
    @PrimaryKey(autoGenerate = true)
    val id: Int,
    val title: String
)
