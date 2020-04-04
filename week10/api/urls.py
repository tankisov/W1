from django.urls import path
from api import views

urlpatterns = [
    path('companies/', views.companies_list),
    path('companies/<int:pk>/', views.company_detail),
    path('companies/<int:pk>/vacancies/', views.company_vacancies),
    path('vacancies/', views.vacancies_list),
    path('vacancies/<int:pk>', views.vacancy_detail),
    path('vacancies/top_ten/', views.vacancies_top)
]