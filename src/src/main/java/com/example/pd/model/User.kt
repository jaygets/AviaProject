package com.example.pd.model

import androidx.room.Entity
import androidx.room.ForeignKey
import androidx.room.PrimaryKey

@Entity(foreignKeys = [
    ForeignKey(
        entity = Office::class,
        parentColumns = arrayOf("id"),
        childColumns = arrayOf("officeId"),
        onDelete = ForeignKey.CASCADE),
    ForeignKey(
        entity = Role::class,
        parentColumns = arrayOf("id"),
        childColumns = arrayOf("roleId"),
        onDelete = ForeignKey.CASCADE)
])
data class User(
    @PrimaryKey(autoGenerate = true)
    val id: Int,
    var officeId: Int,
    var roleId: Int,
    var email: String,
    var password: String,
    var firstName: String,
    var lastName: String,
    var birthday: Long,
    var active: Boolean
)
