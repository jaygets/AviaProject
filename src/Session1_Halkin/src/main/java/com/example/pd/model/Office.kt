package com.example.pd.model

import androidx.room.Entity
import androidx.room.ForeignKey
import androidx.room.PrimaryKey

@Entity(foreignKeys = [
    ForeignKey(
        entity = Country::class,
        parentColumns = arrayOf("id"),
        childColumns = arrayOf("countryId"),
        onDelete = ForeignKey.CASCADE)
])
data class Office (
    @PrimaryKey(autoGenerate = true)
    val id: Int,
    val countryId: Int,
    var title: String,
    var phone: String,
    var contact: String
)