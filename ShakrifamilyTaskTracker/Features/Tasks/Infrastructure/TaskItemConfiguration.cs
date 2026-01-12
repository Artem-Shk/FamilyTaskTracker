using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FamilyTaskTracker.ShakrifamilyTaskTracker.Features.Tasks.Domain;


namespace FamilyTaskTracker.ShakrifamilyTaskTracker.Features.Tasks.Infrastructure
{
    public class TaskItemConfiguration : IEntityTypeConfiguration <TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {
            // Название таблицы
            builder.ToTable("Tasks");

            // Первичный ключ
            builder.HasKey(t => t.Id);

            // Поля
            builder.Property(t => t.title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(t => t.description)
                .HasMaxLength(2000);

            builder.Property(t => t.due_date)
                .IsRequired(false);

            builder.Property(t => t.completed_at)
                .HasDefaultValue(false);

            // Связи
         

            // Индексы
         
        }


    }
}
