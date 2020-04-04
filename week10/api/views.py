from django.shortcuts import render
from django.views.decorators.csrf import csrf_exempt

from api.models import Company, Vacancy
from django.http import JsonResponse


@csrf_exempt
def companies_list(request):
    if request.method == 'GET':
        companies = Company.objects.all()
        companies_json = [c.to_json() for c in companies]
        return JsonResponse(companies_json, safe=False)
    elif request.method == 'POST':
        return JsonResponse({'data': 'company post request'})


@csrf_exempt
def company_detail(request, pk):
    try:
        company = Company.objects.get(id=pk)
    except Company.DoesNotExist as e:
        return JsonResponse({'error: ': str(e)})
    if request.method == 'GET':
        return JsonResponse(company.to_json(), safe=False)


@csrf_exempt
def vacancies_list(request):
    if request.method == 'GET':
        vacancies = Vacancy.objects.all()
        vacancies_json = [v.to_json() for v in vacancies]
        return JsonResponse(vacancies_json, safe=False)
    elif request.method == 'POST':
        return JsonResponse({'data': 'vacancy post request'})


@csrf_exempt
def vacancy_detail(request, pk):
    try:
        vacancy = Vacancy.objects.get(id=pk)
    except Vacancy.DoesNotExist as e:
        return JsonResponse({'error: ' + str(e)})
    if request.method == 'GET':
        return JsonResponse(vacancy.to_json(), safe=False)


@csrf_exempt
def company_vacancies(request, pk):
    try:
        company = Company.objects.get(id=pk)
    except Company.DoesNotExist as e:
        return JsonResponse({'error: ' + str(e)})
    vacancies = company.vacancies.all()
    vacancies_json = [v.to_json() for v in vacancies]
    return JsonResponse(vacancies_json, safe=False)


@csrf_exempt
def vacancies_top(request):
    try:
        vacancies = Vacancy.objects.order_by("-salary")
        vacancies_json = [v.to_json() for v in vacancies]
    except Company.DoesNotExist as e:
        return JsonResponse({'error: ' + str(e)})
    if request.method == 'GET':
        return JsonResponse(vacancies_json, safe=False)
