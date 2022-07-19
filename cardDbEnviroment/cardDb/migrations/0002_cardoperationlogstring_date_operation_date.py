# Generated by Django 4.0.6 on 2022-07-17 15:53

from django.db import migrations, models
import django.utils.timezone


class Migration(migrations.Migration):

    dependencies = [
        ('cardDb', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='cardoperationlogstring',
            name='date',
            field=models.DateTimeField(default=django.utils.timezone.now, verbose_name='OperationDate'),
            preserve_default=False,
        ),
        migrations.AddField(
            model_name='operation',
            name='date',
            field=models.DateTimeField(default=django.utils.timezone.now, verbose_name='OperationDate'),
            preserve_default=False,
        ),
    ]