package com.example.Task4;

import java.nio.file.Files;
import java.nio.file.Paths;

import org.springframework.data.jpa.repository.JpaRepository;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Lob;
import java.io.IOException;
@Entity
public class Image {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;
    private String name;
    private String owner;
    @Lob
    private byte[] data;

    public Image() {}

    public Image(String name, String owner, byte[] data) {
        this.name = name;
        this.owner = owner;
        this.data = data;
    }

    public Image(String name, String owner, String filePath) throws IOException {
        this.name = name;
        this.owner = owner;
        this.data = Files.readAllBytes(Paths.get(filePath));
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getOwner() {
        return owner;
    }

    public void setOwner(String owner) {
        this.owner = owner;
    }

    public byte[] getData() {
        return data;
    }

    public void setData(byte[] data) {
        this.data = data;
    }

}