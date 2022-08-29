﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_Entities.Model;

namespace Test_Entities.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220829193417_db-v-8")]
    partial class dbv8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Test_Entities.Model.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AnswerDescription")
                        .HasColumnType("text");

                    b.HasKey("AnswerId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Test_Entities.Model.Answer_Question", b =>
                {
                    b.Property<int>("Answer_QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AnswerId")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("SurveyId")
                        .HasColumnType("int");

                    b.HasKey("Answer_QuestionId");

                    b.HasIndex("AnswerId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("SurveyId");

                    b.ToTable("Answer_Questions");
                });

            modelBuilder.Entity("Test_Entities.Model.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("QuestionDescription")
                        .HasColumnType("text");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Test_Entities.Model.Survey", b =>
                {
                    b.Property<int>("SurveyId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.HasKey("SurveyId");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("Test_Entities.Model.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TicketCode")
                        .HasColumnType("text");

                    b.HasKey("TicketId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Test_Entities.Model.Answer_Question", b =>
                {
                    b.HasOne("Test_Entities.Model.Answer", "Answer")
                        .WithMany()
                        .HasForeignKey("AnswerId");

                    b.HasOne("Test_Entities.Model.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId");

                    b.HasOne("Test_Entities.Model.Survey", null)
                        .WithMany("Answer_Question")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Test_Entities.Model.Survey", b =>
                {
                    b.HasOne("Test_Entities.Model.Ticket", null)
                        .WithOne("Survey")
                        .HasForeignKey("Test_Entities.Model.Survey", "SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Test_Entities.Model.Survey", b =>
                {
                    b.Navigation("Answer_Question");
                });

            modelBuilder.Entity("Test_Entities.Model.Ticket", b =>
                {
                    b.Navigation("Survey");
                });
#pragma warning restore 612, 618
        }
    }
}
